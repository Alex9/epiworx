﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Xml.Linq;
using Epiworx.Silverlight.Data;

namespace Epiworx.Silverlight.Helpers
{
    public class DataHelper
    {
        public static string ServiceUri
        {
            get { return Application.Current.Resources["serviceUri"].ToString(); }
        }

        public static string ServiceApiKey
        {
            get { return Application.Current.Resources["serviceApiKey"].ToString(); }
        }

        public static IEnumerable<HourData> GetHours(DateTime start, DateTime end)
        {
            var uri = string.Format("{0}Hours?apikey={1}", ServiceUri, ServiceApiKey);

            uri += "&start=";
            uri += start.ToShortDateString();
            uri += "&end=";
            uri += end.ToShortDateString();

            var xml = XElement.Load(uri);
            var ns = xml.GetDefaultNamespace();
            var hours = xml.Elements(ns + "HourData");

            return hours
                .Select(hour => new HourData(hour))
                .ToList();
        }

        public static IEnumerable<ProjectData> GetProjects()
        {
            var uri = string.Format("{0}Projects?apikey={1}", ServiceUri, ServiceApiKey);

            var xml = XElement.Load(uri);
            var ns = xml.GetDefaultNamespace();
            var projects = xml.Elements(ns + "ProjectData");

            return projects
                .Select(project => new ProjectData(project))
                .ToList();
        }
    }
}