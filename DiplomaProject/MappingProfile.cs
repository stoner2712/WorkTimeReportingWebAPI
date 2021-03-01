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
            CreateMap<EmployeeDtoCreate, Employee>();

            CreateMap<TimeEntry, TimeEntryDto>();
            CreateMap<TimeEntryDtoCreate, TimeEntry>();
        }
    }
}

