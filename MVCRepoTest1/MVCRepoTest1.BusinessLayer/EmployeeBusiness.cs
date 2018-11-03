using MVCRepoTest1.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRepoTest1.BusinessLayer
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        public string GetEmployeeName(string EmpID)
        {

            return "Jessie " + EmpID;
        }
    }
}
