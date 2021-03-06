﻿using System;
using System.IO;

namespace NPS.AKRO.ArcGIS.Common
{
    internal class Settings
    {
        internal static string Get(string setting)
        {
            string datafile = Path.Combine(AssemblyDirectory, setting + ".txt");
            try
            {
                using (var file = File.OpenText(datafile))
                {
                    return file.ReadToEnd();
                }
            }
            catch
            {
                return null;
            }
        }

        private static string AssemblyDirectory
        {
            get
            {
                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }
}
