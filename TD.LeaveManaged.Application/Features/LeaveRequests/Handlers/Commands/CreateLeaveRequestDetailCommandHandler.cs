using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.LeaveRequest.Validators;
using TD.LeaveManaged.Application.Exceptions;
using TD.LeaveManaged.Application.Features.LeaveRequests.Requests.Commands;
using TD.LeaveManaged.Application.Features.LeaveRequests.Responses;
using TD.LeaveManaged.Application.Persistence.Contracts;
using TD.LeaveManagement.Domain;

namespace TD.LeaveManaged.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestDetailCommandHandler : IRequestHandler<CreateLeaveRequestDetailCommand, LeaveRequestCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestDetailCommandHandler(ILeaveRequestRepository leaveRequestRepository,ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestCommandResponse> Handle(CreateLeaveRequestDetailCommand request, CancellationToken cancellationToken)
        {
            var response = new LeaveRequestCommandResponse();
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.leaveRequestDto);
            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Could not create a leave request in this moment.";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            } 

            var leaveRequest = _mapper.Map<LeaveRequest>(request.leaveRequestDto);
            leaveRequest= await _leaveRequestRepository.Add(leaveRequest);

            response.Success = true;
            response.Message = "Leave request created successfully.";
            response.Id = leaveRequest.Id;

            return response;
        }
    }
}
