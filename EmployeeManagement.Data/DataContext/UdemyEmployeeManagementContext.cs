using EmployeeManagement.Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.DataContext
{
    public class UdemyEmployeeManagementContext: IdentityDbContext
    {
        public UdemyEmployeeManagementContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }

        public DbSet<EmployeeLeaveType> EmployeeLeaveType { get; set; }

    }
}

