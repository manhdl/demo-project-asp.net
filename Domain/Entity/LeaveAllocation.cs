using Domain.Common;

namespace Domain.Entity
{
    public class LeaveAllocation : BaseEntity<int>
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
