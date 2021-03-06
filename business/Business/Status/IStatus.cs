using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epiworx.Business
{
    public interface IStatus
    {
        int StatusId { get; }
        string Name { get; }
        string Description { get; }
        int Ordinal { get; }
        string ForeColor { get; }
        string BackColor { get; }
        bool IsStarted { get; }
        bool IsCompleted { get; }
        bool IsActive { get; }
        bool IsArchived { get; }
        int ModifiedBy { get; }
        string ModifiedByName { get; }
        DateTime ModifiedDate { get; }
        int CreatedBy { get; }
        string CreatedByName { get; }
        DateTime CreatedDate { get; }
    }
}
