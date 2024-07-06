using Application.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Commands.UpdateLeaveType
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leavetypeToUpdate = _mapper.Map<Domain.Entity.LeaveType>(request);

            await _leaveTypeRepository.UpdateAsync(leavetypeToUpdate);

            return Unit.Value;
        }
    }
}
