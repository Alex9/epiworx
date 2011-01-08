using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epiworx.Business
{
    public partial class HourInfo
    {
        private void Fetch(Data.Hour data)
        {
            this.LoadProperty(HourIdProperty, data.HourId);
            this.LoadProperty(TaskIdProperty, data.TaskId);
            this.LoadProperty(TaskNameProperty, data.Task.Description);
            this.LoadProperty(ProjectIdProperty, data.Task.ProjectId);
            this.LoadProperty(ProjectNameProperty, data.Task.Project.Name);
            this.LoadProperty(UserIdProperty, data.UserId);
            this.LoadProperty(UserNameProperty, data.User.Name);
            this.LoadProperty(DateProperty, data.Date);
            this.LoadProperty(DurationProperty, data.Duration);
            this.LoadProperty(LabelsProperty, data.Labels);
            this.LoadProperty(IsArchivedProperty, data.IsArchived);
            this.LoadProperty(NotesProperty, data.Notes);
            this.LoadProperty(ModifiedByProperty, data.ModifiedBy);
            this.LoadProperty(ModifiedByNameProperty, data.ModifiedByUser.Name);
            this.LoadProperty(ModifiedDateProperty, data.ModifiedDate);
            this.LoadProperty(CreatedByProperty, data.CreatedBy);
            this.LoadProperty(CreatedByNameProperty, data.CreatedByUser.Name);
            this.LoadProperty(CreatedDateProperty, data.CreatedDate);
        }
    }
}