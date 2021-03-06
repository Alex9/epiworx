﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Epiworx.Business;

namespace Epiworx.WebMvc.Models
{
    public class HomeIndexModel : ModelBase
    {
        public string Dashboard { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<IFeed> Feeds { get; set; }
        public IEnumerable<IHour> Hours { get; set; }
        public IEnumerable<IProject> Projects { get; set; }
        public IEnumerable<ITask> Tasks { get; set; }
    }

    public class HomeSettingsModel : ModelBase
    {
        public IEnumerable<ICategory> Categories { get; set; }
        public IEnumerable<IStatus> Statuses { get; set; }
    }
}