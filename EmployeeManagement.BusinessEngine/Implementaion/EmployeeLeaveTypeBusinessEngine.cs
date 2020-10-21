using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EmployeeManagement.BusinessEngine.Contracts;
using EmployeeManagement.Common.ConstantsModels;
using EmployeeManagement.Common.ResultModels;
using EmployeeManagement.Common.VModels;
using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DbModels;


namespace EmployeeManagement.BusinessEngine.Implementaion
{
    public class EmployeeLeaveTypeBusinessEngine : IEmployeeLeaveTypeBusinessEngine
    {
        #region Variable

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region CustomMethods
        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes()
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.GetAll().ToList();
            #region 1.YÖNTEM
            //if (data != null)
            //{
            //    List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();
            //    foreach (var item in data)
            //    {
            //        returnData.Add(new EmployeeLeaveType()
            //        {
            //            Id = item.Id,
            //            DateCreated = item.DateCreated,
            //            DefaultDays = item.DefaultDays,
            //            Name = item.Name

            //        });

            //    }
            //    return new Result<List<EmployeeLeaveType>>(true, ResultConstant.RecordFound, returnData);
            //}
            //else
            //{
            //    return new Result<List<EmployeeLeaveType>>(false, ResultConstant.RecordNotFound);
            //}
            #endregion

            var leaveTypes =_mapper.Map<List<EmployeeLeaveType>,List< EmployeeLeaveTypeVM >> (data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstant.RecordFound, leaveTypes);
            #endregion
        }

        
    }
}