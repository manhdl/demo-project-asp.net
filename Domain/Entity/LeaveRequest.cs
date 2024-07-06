using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class LeaveRequest : AuditableEntity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsApproved { get; set;}
        public string RequestingEmployeeId { get; set; }
    }
}
