using Application.Exceptions;
using Application.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Commands.DelateLeaveType
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var LeaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);

            if(LeaveTypeToDelete == null)
                throw new NotFoundException(nameof(LeaveType), request.Id);

            await _leaveTypeRepository.DeleteAsync(LeaveTypeToDelete);

            return Unit.Value;
        }
    }
}
