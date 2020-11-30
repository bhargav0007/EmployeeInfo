using AutoMapper;
using EmployeeAccessor.IAccessor;
using EmployeeManager.IEmployeeManager;
using EmployeeManager.ViewModals;
using System;
using System.Collections.Generic;

namespace EmployeeManager
{
    public class EmpManager : IEmpManager
    {
        private readonly IEmpAccessor _empAccessor;
        private readonly IMapper _mapper;

        public EmpManager(IEmpAccessor empAccessor, IMapper mapper)
        {
            _empAccessor = empAccessor;
            this._mapper = mapper;
        }

        public List<EmployeeViewModal> getEmployeeView()
        {
            var results = _empAccessor.GetEmployees();
            List<EmployeeViewModal> result = _mapper.Map<List<EmployeeViewModal>>(results);
            return result;

        }
    }
}
