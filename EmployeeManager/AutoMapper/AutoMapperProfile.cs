using AutoMapper;
using EmployeeAccessor.Models;
using EmployeeManager.ViewModals;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager.AutoMapper
{
   public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile() {

            CreateMap<EmployeeViewModal, Employee>().ReverseMap();
        }
    }
}
