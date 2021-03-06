﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Epiworx.Business;
using Epiworx.Core;

namespace Epiworx.WebMvc.Models
{
    public class ProjectTasksByCategoryListModel : ModelListBase
    {
        public int ProjectId { get; set; }
        public IEnumerable<ITask> Tasks { get; set; }
        public IEnumerable<ICategory> Categories { get; set; }
    }

    public class ProjectTasksByStatusListModel : ModelListBase
    {
        public int ProjectId { get; set; }
        public IEnumerable<ITask> Tasks { get; set; }
        public IEnumerable<IStatus> Statuses { get; set; }
    }

    public class ProjectIndexModel : ProjectListModel
    {
    }

    public class ProjectListModel : ModelListBase
    {
        public int IsActive { get; set; }
        public int IsArchived { get; set; }
        public IQueryable<INote> Notes { get; set; }
        public IQueryable<IProject> Projects { get; set; }
    }

    public class ProjectFormModel : ModelBusinessBase
    {
        public int ProjectId { get; set; }

        [DisplayName("Name:")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DisplayName("Description:")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [DisplayName("Enter some notes about the project:")]
        public string Notes { get; set; }

        [DisplayName("This project is active")]
        public bool IsActive { get; set; }

        [DisplayName("This project is archived")]
        public bool IsArchived { get; set; }

        public IEnumerable<ITask> Tasks { get; set; }
        public IEnumerable<ISprint> Sprints { get; set; }
        public IEnumerable<ICategory> Categories { get; set; }
        public IEnumerable<IStatus> Statuses { get; set; }
        public NoteListModel NoteListModel { get; set; }
        public AttachmentListModel AttachmentListModel { get; set; }
    }
}