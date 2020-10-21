using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Implementaion
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly UdemyEmployeeManagementContext _ctx;
        public EmployeeLeaveTypeRepository(UdemyEmployeeManagementContext ctx) : base(ctx)
        {
        }
    }
}
