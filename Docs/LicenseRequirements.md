License Level Requirements

Alaska Pak Command, Class file, toolbox command, license level
Add Attribute->Add Globally Unique Id, AddGUID.cs, AddGlobalIDs_management, ArcEditor
Grids->Generate Grid Points, GenerateGridPoints, FeatureToPoint_management, ArcInfo
Conversions->Polyline/Polygon To Point, PolygonToPoint.cs, FeatureVerticesToPoints_management, ArcInfo
Randomize->Random Points, RandomPoints.cs, CreateRandomPoints_management, ArcInfo or Spatial Analyst, or 3D Analyst
Conversions->Point To Polygon, Point2Poly.py, FeatureToPolygon_management, ArcInfo
Randomize->Obscure Points, ObscurePoints.py, CreateRandomPoints_management, ArcInfo if using No Go or Must Go Areas


AddArea.py: ArcView
	AddField_management, ArcView
	CalculateField_management, ArcView
AddID.py: ArcView
	AddField_management, ArcView
AddLength.py: ArcView
	AddField_management, ArcView
	CalculateField_management, ArcView
Line2Rect.py: ArcView
	CreateFeatureclass_management, ArcView
ObscurePoints.py: ArcInfo (if using No Go or Must Go Areas), ArcView otherwise
	FeatureClassToFeatureClass_conversion, ArcView
	Delete_management, ArcView
	Buffer_analysis, ArcView
	Erase_analysis (CreateLimitedPoints), Arcinfo
	Clip_analysis, ArcView
	CreateRandomPoints_management (CreateLimitedPoints), ArcInfo or Spatial Analyst, or 3D Analyst
	JoinField_management (CreateLimitedPoints), ArcInfo
	DeleteField_management, ArcView
Point2Poly.py: ArcInfo
	PointsToLine_management, ArcView
	FeatureToPolygon_management, ArcInfo
RandomTransects.py: ArcView
	CreateFeatureclass_management, ArcView
SquareBuilding.py: ArcView
	CopyFeatures_management, ArcView
	AddField_management, ArcView
	CalculateField_management, ArcView
	DeleteField_management, ArcView
	Line2Rect.py, ArcView
Table2Shape.py: ArcView
	CreateFeatureclass_management, ArcView
	AddField_management, ArcView
	