using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epiworx.Business
{
    public partial class InvoiceInfo
    {
        private void Fetch(Data.Invoice data)
        {
            this.LoadProperty(InvoiceIdProperty, data.InvoiceId);
            this.LoadProperty(NumberProperty, data.Number);
            this.LoadProperty(ProjectIdProperty, data.Task.ProjectId);
            this.LoadProperty(ProjectNameProperty, data.Task.Project.Name);
            this.LoadProperty(DescriptionProperty, data.Description);
            this.LoadProperty(TaskIdProperty, data.TaskId);
            this.LoadProperty(PreparedDateProperty, data.PreparedDate);
            this.LoadProperty(AmountProperty, data.Amount);
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
