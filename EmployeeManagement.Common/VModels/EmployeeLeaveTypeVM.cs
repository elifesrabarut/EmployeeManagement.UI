using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveTypeVM:BaseVM
    {
        [Required]//zorunlu alanlar
        public string Name { get;protected set; }
        public int DefaultDays { get; protected set; }



        public int DefaultDays22 { get; protected set; }
        public DateTime DateCreated { get;protected set; }
        //MVM create EmployeeType
        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}
