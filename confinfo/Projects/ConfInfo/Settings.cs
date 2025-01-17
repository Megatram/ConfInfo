﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace ConfInfo
{
    public static class Settings
    {
        private const string settings_file = @"\\mtfs003\va_data4$\ProgramData\Vision\PublishedScripts\Settings.xml";

        public static string ARIA_SERVER = getFromXml(settings_file, "ARIA_SERVER");
        public static string ARIA_USERNAME = getFromXml(settings_file, "ARIA_USERNAME");
        public static string ARIA_PASSWORD = getFromXml(settings_file, "ARIA_PASSWORD");
        public static string ARIA_DATABASE = getFromXml(settings_file, "ARIA_DATABASE");

        public static string RESULT_SERVER = getFromXml(settings_file, "RESULT_SERVER");
        public static string RESULT_USERNAME = getFromXml(settings_file, "RESULT_USERNAME");
        public static string RESULT_PASSWORD = getFromXml(settings_file, "RESULT_PASSWORD");

        private static string getFromXml(string file, string varible)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            return doc.SelectSingleNode("Settings/" + varible).InnerText;
        }
    }
}
