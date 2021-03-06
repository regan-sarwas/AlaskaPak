﻿using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AlaskaPak
{
    internal class AlaskaPakModule : Module
    {
        private static AlaskaPakModule _this = null;

        /// <summary>
        /// Retrieve the singleton instance to this module here
        /// </summary>
        public static AlaskaPakModule Current
        {
            get
            {
                return _this ?? (_this = (AlaskaPakModule)FrameworkApplication.FindModule("AlaskaPak_Module"));
            }
        }

        public static string ToolboxPath => @"C:\Users\RESarwas\Documents\GitHub\AlaskaPak\GPTools\AlaskaPak.pyt";

        public static string ThemeManagerPath => @"X:\GIS\ThemeMgrApp\Pro\ThemeManager.exe";

        #region Overrides
        /// <summary>
        /// Called by Framework when ArcGIS Pro is closing
        /// </summary>
        /// <returns>False to prevent Pro from closing, otherwise True</returns>
        protected override bool CanUnload()
        {
            //TODO - add your business logic
            //return false to ~cancel~ Application close
            return true;
        }

        #endregion Overrides

    }
}
