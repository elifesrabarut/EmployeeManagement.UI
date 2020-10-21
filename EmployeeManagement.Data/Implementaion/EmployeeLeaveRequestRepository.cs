using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Implementaion
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequestRepository
    {
        private readonly UdemyEmployeeManagementContext _ctx;
        public EmployeeLeaveRequestRepository(UdemyEmployeeManagementContext ctx) : base(ctx)
        {

        }
    }
}
