# ------------------------------------------------------------------------------
# Line2Rect.py
# Created: 2011-01-14
# Author: Regan Sarwas, National Park Service
#
# Builds a polygon feature class containing rectangles derived from a line
# feature class.  The line is used as the base of the rectangle, and an
# attribute in the line feature class provides the height.  If the height is
# positive, the rectangle is drawn on the right side of the line.  If it is
# negative it is drawn on the left side.  Right and left are determined by the
# order of the vertices in the line.
#
# * The input lines features can have any number of parts, and any number of
# vertices in each part, however only the first and last vertex are used in
# the output rectangle.  If the input shape is a multipart, then the output
# shape is also multipart.
# * if the line (or part) is degenerate (i.e single vertex, or first vertex
# and last vertext are the same (based on tolerance in the environment)) then
# the line (or part) is skipped. If all parts in the input shape are degenerate
# then no output feature is created for that input feature.
# * The output feature class will have the same spatial reference as the input
# * If the Input feature class has Z or M defined, the output will as well,
# however, no Z or M values will be written to the output. 
# * The offset must be a numeric field, and it will be interpreted as a double
# in the same units/coordinate system as the line feature class.
# * All attributes of the line feature class are copied forward to the output
# feature class, except Shape, OID, and any fields not editable (Shape_Length)
# * the offset field name can be either an actual field name, or the alias for
# the field name.  Actual field names are given priority in case of ambiguity 
# * The output feature class must not exist unless the user's environment is
# set to allow overwrite
#
# Requirements
# arcpy module - requires ArcGIS v10+ and a valid license
#
# Usage:
# python Line2Rect.py path_to_lineFC Offset_Field_Name path_to_outputFC
#
# Example:
# python Line2Rect.py "c:\tmp\gps_lines.shp" "width" "c:\tmp\test.gdb\park\bldg"
#
# License:
# Public Domain
#
# Disclaimer:
# This software is provide "as is" and the National Park Service gives
# no warranty, expressed or implied, as to the accuracy, reliability,
# or completeness of this software. Although this software has been
# processed successfully on a computer system at the National Park
# Service, no warranty expressed or implied is made regarding the
# functioning of the software on another system or for general or
# scientific purposes, nor shall the act of distribution constitute any
# such warranty. This disclaimer applies both to individual use of the
# software and aggregate use with other software.
# ------------------------------------------------------------------------------

#FIXME
# *output to a feature dataset in a PGDB fails (for shape and FGDB input)
# Line2Rect.py lines.shp width c:\tmp\test.mdb\park\rect2
# Traceback (most recent call last):
#  File "Line2Rect.py", line 187, in <module>
#    poly.setValue(fields[field], line.getValue(field))
#  File "C:\Program Files (x86)\ArcGIS\Desktop10.0\arcpy\arcpy\arcobjects\arcobjects.py", line 941, in setValue
#    return convertArcObjectToPythonObject(self._arc_object.SetValue(*gp_fixargs(args)))
# RuntimeError: ERROR 999999: Error executing function.

# *creating rects in PGDB works except one rectangle (width = 1000) is missing

import sys, os, math
import arcpy

def MakeRect(pt1, pt2, width):
    """Assumes pt1 and pt2 are arcpy.Points, and width is numeric.
    Returns a tuple of the next two points in the rectangle.
    Points proceed clockwise for a positive width and
    counterclockwise for a negative width."""
    #Find the angle of the line between the points
    dx = pt2.X - pt1.X
    dy = pt2.Y - pt1.Y
    angle = math.atan2(dy,dx)
    #find the endpoint of a line width long and 
    #rotated 90 degrees to the right
    angle = angle - math.pi/2.0
    y = width * math.sin(angle)
    x = width * math.cos(angle)
    #add that end point to the two points given 
    pt3 = arcpy.Point(pt2.X + x, pt2.Y + y)
    pt4 = arcpy.Point(pt1.X + x, pt1.Y + y)
    return (pt3,pt4)

def MakeRectFromLine(line, width):
    """Assumes an arcpy.Polyline for input, and returns an
    arcpy.Polygon or None.  If the input is multipart, so is output.
    Any degenerate parts (single vertex, or first == last) are
    ignored.  If all parts are degenerate, None is returned."""
    # skip bad shapes
    if line.partCount == 0:
        return None
    #skip bad width
    if width == None or width == 0:
        return None
    if line.isMultipart:
        parray = arcpy.Array()
        parts = line.getPart()
        for part in parts:
            #part is an array of points
            if len(part) == 0:
                continue #bad part
            pt1 = part[0]
            pt2 = part[len(part)-1]
            if pt1.equals(pt2):
                continue #baseline for rect cannot be a point
            pt3,pt4 = MakeRect(pt1, pt2, width)
            parray.add(arcpy.Array([pt1, pt2, pt3, pt4, pt1]))
        if (len(parray) == 0):
            return None
        return arcpy.Polygon(parray)
    else:
        pt1 = line.firstPoint
        pt2 = line.lastPoint
        if pt1.equals(pt2): #this equals is an arcpy method
            return None
        pt3,pt4 = MakeRect(pt1, pt2, width)
        return arcpy.Polygon(arcpy.Array([pt1, pt2, pt3, pt4, pt1]))


    
#Get and check input
if len(sys.argv) != 4:
    arcpy.AddError("This tool requires exactly 3 parameters.")
    print ("Usage: " + sys.argv[0] +
          " path_to_lineFC Offset_Field_Name path_to_outputFC")
    sys.exit(1)
    
lineFC = arcpy.GetParameterAsText(0)
offsetFN = arcpy.GetParameterAsText(1)
rectFC = arcpy.GetParameterAsText(2)

lineDescription = arcpy.Describe(lineFC)

if lineDescription.shapeType != "Polyline":
    arcpy.AddError(lineFC +" is a " + lineDescription.shapeType +
                   " not Polyline feature class")
    sys.exit(1)

offsetFieldType = ""
#check for offsetFN in the field names
for field in lineDescription.fields:
    if field.name == offsetFN:
        offsetFieldType = field.type
        break

#check for offsetFN in the field alias names
if offsetFieldType == "":
    for field in lineDescription.fields:
        if field.aliasName == offsetFN:
            offsetFieldType = field.type
            break

if offsetFieldType == "":
    arcpy.AddError(offsetFN +" was not found as a field in " + lineFC)
    sys.exit(1)
        
if  (offsetFieldType != "SmallInteger" and
     offsetFieldType != "Integer" and
     offsetFieldType != "Single" and
     offsetFieldType != "Double"):
    arcpy.AddError(offsetFN +"(" + offsetFieldType +
                   ") is not a numeric data type")
    sys.exit(1)

#arcpy.AddMessage("Input has been validated")

#start the real work
workspace,featureClass = os.path.split(rectFC)
arcpy.CreateFeatureclass_management(workspace,featureClass, 
                                    "Polygon", lineFC, "SAME_AS_TEMPLATE",
                                    "SAME_AS_TEMPLATE", lineFC)

#arcpy.AddMessage("Empty feature class has been created")

#create a simple field mapping from input to output
fields = {}
for field in lineDescription.fields:
    name = field.name
    if (name != lineDescription.shapeFieldName and
        name != lineDescription.OIDFieldName and
        field.editable): #skip uneditable fields like Shape_Length
        fields[name] = arcpy.ValidateFieldName(name,workspace)
print fields

#create the cursors
polys = arcpy.InsertCursor(rectFC)
lines = arcpy.SearchCursor(lineFC)
for line in lines:
    if line.shape:
        poly = polys.newRow()
        rect = MakeRectFromLine(line.shape, line.getValue(offsetFN))
        if rect:
            for field in fields:
                poly.setValue(fields[field], line.getValue(field))
            poly.shape = rect
            polys.insertRow(poly)

#arcpy.AddMessage("Output feature class has been populated")

#delete the insert cursor to close it and remove the exclusive lock
del polys
