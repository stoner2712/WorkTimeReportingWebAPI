using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeCreateDto, Employee>();

            CreateMap<TimeEntry, TimeEntryDto>();
            CreateMap<TimeEntryCreateDto, TimeEntry>();

            CreateMap<Client, ClientDto>();
            CreateMap<ClientCreateDto, Client>();

            CreateMap<Project, ProjectDto>();
            CreateMap<ProjectCreateDto, Project>();

            CreateMap<Invoice, InvoiceDto>();
            CreateMap<InvoiceCreateDto, Invoice>();

            CreateMap<Invoice, InvoiceForProjectDto>()
                .Include<Invoice, InvoiceForClientDto>()
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(dest => dest.ProjectName, opt => opt.MapFrom(src => src.Project.ProjectName))
                ;

            CreateMap<Invoice, InvoiceForClientDto>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Project.ClientId))
                .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Project.Client.ClientName));

            CreateMap<Invoice, InvoiceForTimeEntryDto>();

            CreateMap<Invoice, InvoicePeriodClosureDto>();
        }
    }
}

