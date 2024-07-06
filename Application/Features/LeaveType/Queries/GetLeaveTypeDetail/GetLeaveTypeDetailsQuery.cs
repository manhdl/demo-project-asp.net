using MediatR;

namespace Application.Features.LeaveType.Queries.GetLeaveTypeDetail
{
    public record GetLeaveTypeDetailsQuery(int id) : IRequest<LeaveTypeDetailDto>;
}
