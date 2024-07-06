using MediatR;

namespace Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public record GetAllLeaveTypeQuery : IRequest<List<LeaveTypeDto>>;
}
