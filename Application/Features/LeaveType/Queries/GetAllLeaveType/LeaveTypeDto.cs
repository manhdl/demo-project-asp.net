namespace Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public class LeaveTypeDto
    {
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
