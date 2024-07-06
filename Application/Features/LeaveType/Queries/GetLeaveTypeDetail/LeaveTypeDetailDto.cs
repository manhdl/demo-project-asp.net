namespace Application.Features.LeaveType.Queries.GetLeaveTypeDetail
{
    public class LeaveTypeDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
