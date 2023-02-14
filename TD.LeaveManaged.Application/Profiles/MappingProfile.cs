using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TD.LeaveManaged.Application.DTOs;
using TD.LeaveManaged.Application.DTOs.LeaveRequest;
using TD.LeaveManagement.Domain;

namespace TD.LeaveManaged.Application.Profiles
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
