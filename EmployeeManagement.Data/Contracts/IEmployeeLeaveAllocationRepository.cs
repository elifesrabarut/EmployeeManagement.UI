using EmployeeManagement.Data.DbModels;
using EmployeeManagement.Data.Implementaion;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Contracts
{
    public interface IEmployeeLeaveAllocationRepository: IRepositoryBase<EmployeeLeaveAllocation>
    {
    }
}
