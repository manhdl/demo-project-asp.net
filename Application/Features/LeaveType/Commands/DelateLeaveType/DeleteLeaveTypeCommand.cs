using MediatR;

namespace Application.Features.LeaveType.Commands.DelateLeaveType
{
    public class DeleteLeaveTypeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
