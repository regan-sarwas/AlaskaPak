//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NPS.AKRO.ArcGIS {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal class ThisAddIn {
        
        internal static string Name {
            get {
                return "Alaska Pak";
            }
        }
        
        internal static string AddInID {
            get {
                return "{f27bc194-1406-4cd9-ab22-067660801251}";
            }
        }
        
        internal static string Company {
            get {
                return "National Park Service, Alaska Regional Office";
            }
        }
        
        internal static string Version {
            get {
                return "3.0";
            }
        }
        
        internal static string Description {
            get {
                return "A tool kit for increasing GIS productivity";
            }
        }
        
        internal static string Author {
            get {
                return "Regan Sarwas, GIS Team";
            }
        }
        
        internal static string Date {
            get {
                return "12/2/2010";
            }
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Coordinates', the id declared for Add-in Tool class 'Coordinates'
            /// </summary>
            internal static string Coordinates {
                get {
                    return "NPS_Alaska_Pak_Coordinates";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Generate_Grid', the id declared for Add-in Tool class 'GenerateGrid'
            /// </summary>
            internal static string GenerateGrid {
                get {
                    return "NPS_Alaska_Pak_Generate_Grid";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_ThemeManager', the id declared for Add-in Button class 'ThemeManager'
            /// </summary>
            internal static string ThemeManager {
                get {
                    return "NPS_Alaska_Pak_ThemeManager";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Add_Unique_ID', the id declared for Add-in Button class 'AddUniqueID'
            /// </summary>
            internal static string AddUniqueID {
                get {
                    return "NPS_Alaska_Pak_Add_Unique_ID";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Add_XY', the id declared for Add-in Button class 'AddXY'
            /// </summary>
            internal static string AddXY {
                get {
                    return "NPS_Alaska_Pak_Add_XY";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Add_Acres', the id declared for Add-in Button class 'AddAcres'
            /// </summary>
            internal static string AddAcres {
                get {
                    return "NPS_Alaska_Pak_Add_Acres";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Add_Miles', the id declared for Add-in Button class 'AddMiles'
            /// </summary>
            internal static string AddMiles {
                get {
                    return "NPS_Alaska_Pak_Add_Miles";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Obscure_Points', the id declared for Add-in Button class 'ObscurePoints'
            /// </summary>
            internal static string ObscurePoints {
                get {
                    return "NPS_Alaska_Pak_Obscure_Points";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Random_Points', the id declared for Add-in Button class 'RandomPoints'
            /// </summary>
            internal static string RandomPoints {
                get {
                    return "NPS_Alaska_Pak_Random_Points";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Transects', the id declared for Add-in Button class 'RandomTransects'
            /// </summary>
            internal static string RandomTransects {
                get {
                    return "NPS_Alaska_Pak_Transects";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Random_Select', the id declared for Add-in Button class 'RandomSelect'
            /// </summary>
            internal static string RandomSelect {
                get {
                    return "NPS_Alaska_Pak_Random_Select";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Point_to_Polygon', the id declared for Add-in Button class 'PointToPolygon'
            /// </summary>
            internal static string PointToPolygon {
                get {
                    return "NPS_Alaska_Pak_Point_to_Polygon";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Polygon_to_Point', the id declared for Add-in Button class 'PolygonToPoint'
            /// </summary>
            internal static string PolygonToPoint {
                get {
                    return "NPS_Alaska_Pak_Polygon_to_Point";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Generate_Grid_Points', the id declared for Add-in Button class 'GenerateGridPoints'
            /// </summary>
            internal static string GenerateGridPoints {
                get {
                    return "NPS_Alaska_Pak_Generate_Grid_Points";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Resize_Grid', the id declared for Add-in Button class 'ResizeGrid'
            /// </summary>
            internal static string ResizeGrid {
                get {
                    return "NPS_Alaska_Pak_Resize_Grid";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Set_All_Extents', the id declared for Add-in Button class 'SetExtents'
            /// </summary>
            internal static string SetExtents {
                get {
                    return "NPS_Alaska_Pak_Set_All_Extents";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Animate_Features', the id declared for Add-in Button class 'AnimateFeatures'
            /// </summary>
            internal static string AnimateFeatures {
                get {
                    return "NPS_Alaska_Pak_Animate_Features";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Square_Building', the id declared for Add-in Button class 'SquareBuildings'
            /// </summary>
            internal static string SquareBuildings {
                get {
                    return "NPS_Alaska_Pak_Square_Building";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Copy_Raster_Symbology', the id declared for Add-in Button class 'CopyRasterSymbology'
            /// </summary>
            internal static string CopyRasterSymbology {
                get {
                    return "NPS_Alaska_Pak_Copy_Raster_Symbology";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_About', the id declared for Add-in Button class 'AlaskaPakAbout'
            /// </summary>
            internal static string AlaskaPakAbout {
                get {
                    return "NPS_Alaska_Pak_About";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Link_Internal', the id declared for Add-in Button class 'LinkInternal'
            /// </summary>
            internal static string LinkInternal {
                get {
                    return "NPS_Alaska_Pak_Link_Internal";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Link_External', the id declared for Add-in Button class 'LinkExternal'
            /// </summary>
            internal static string LinkExternal {
                get {
                    return "NPS_Alaska_Pak_Link_External";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Help', the id declared for Add-in Button class 'AlaskaPakHelp'
            /// </summary>
            internal static string AlaskaPakHelp {
                get {
                    return "NPS_Alaska_Pak_Help";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Coordinates_Place_Marker', the id declared for Add-in Button class 'CoordinatesPlaceMarker'
            /// </summary>
            internal static string CoordinatesPlaceMarker {
                get {
                    return "NPS_Alaska_Pak_Coordinates_Place_Marker";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Coordinates_Copy_Text', the id declared for Add-in Button class 'CoordinatesCopyText'
            /// </summary>
            internal static string CoordinatesCopyText {
                get {
                    return "NPS_Alaska_Pak_Coordinates_Copy_Text";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Coordinates_Zoom_To_Marker', the id declared for Add-in Button class 'CoordinatesZoomToMarker'
            /// </summary>
            internal static string CoordinatesZoomToMarker {
                get {
                    return "NPS_Alaska_Pak_Coordinates_Zoom_To_Marker";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Coordinates_Set_Mode_Interactive', the id declared for Add-in Button class 'CoordinatesSetModeInteractive'
            /// </summary>
            internal static string CoordinatesSetModeInteractive {
                get {
                    return "NPS_Alaska_Pak_Coordinates_Set_Mode_Interactive";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Coordinates_Set_Mode_Locked', the id declared for Add-in Button class 'CoordinatesSetModeLocked'
            /// </summary>
            internal static string CoordinatesSetModeLocked {
                get {
                    return "NPS_Alaska_Pak_Coordinates_Set_Mode_Locked";
                }
            }
            
            /// <summary>
            /// Returns 'NPS_Alaska_Pak_Coordinates_Set_Mode_Feature', the id declared for Add-in Button class 'CoordinatesSetModeFeature'
            /// </summary>
            internal static string CoordinatesSetModeFeature {
                get {
                    return "NPS_Alaska_Pak_Coordinates_Set_Mode_Feature";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;

      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
