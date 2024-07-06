using Application.Exceptions;
using Application.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var createLeaveTypeValidate = new CreateLeaveTypeCommandValidator(_leaveTypeRepository);
            var validationResult = await createLeaveTypeValidate.ValidateAsync(request);

            if (validationResult.Errors.Any())
                throw new BadRequestException("tesst");

            var leaveTypeToCreate = _mapper.Map<Domain.Entity.LeaveType>(request);

            var data = await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);

            return data.Id;
        }
    }
}
