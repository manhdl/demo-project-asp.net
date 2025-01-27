﻿using Application.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Queries.GetLeaveTypeDetail
{
    public class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailsQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetByIdAsync(request.id);

            var data = _mapper.Map<LeaveTypeDetailDto>(leaveType);

            return data;
        }
    }
}
