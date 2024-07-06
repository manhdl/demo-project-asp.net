using Domain.Common;

namespace Domain.Entity
{
    public class LeaveType : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
