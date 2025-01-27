﻿using MediatR;

namespace Application.Features.LeaveType.Commands.CreateLeaveType
{
    public record CreateLeaveTypeCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
