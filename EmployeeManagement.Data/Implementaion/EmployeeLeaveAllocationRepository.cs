using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Implementaion
{
    public class EmployeeLeaveAllocationRepository:Repository<EmployeeLeaveAllocation>, Contracts.IEmployeeLeaveAllocationRepository
    {
        private readonly UdemyEmployeeManagementContext _ctx;
        public EmployeeLeaveAllocationRepository(UdemyEmployeeManagementContext ctx):base(ctx)
        {
            _ctx = _ctx;
        }
    }
}
