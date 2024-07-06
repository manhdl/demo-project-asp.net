using Application.Features.LeaveType.Queries.GetAllLeaveType;
using Application.Features.LeaveType.Queries.GetLeaveTypeDetail;
using AutoMapper;
using Domain.Entity;

namespace Application.MappingProfile
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveTypeDetailDto, LeaveType>().ReverseMap();
        }
    }
}
