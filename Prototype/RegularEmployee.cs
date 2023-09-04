using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class RegularEmployee : EmployeeProtoType
    {
        public override EmployeeProtoType DeepCopy()
        {
           RegularEmployee emp = new RegularEmployee();
            emp = (RegularEmployee)this.MemberwiseClone();
            emp.Name = this.Name;
            emp.Address = new Address { Building = emp.Address.Building,
                                        City=emp.Address.City,
                                        StreetName=emp.Address.StreetName };
            return emp;
        }

        public override EmployeeProtoType ShallowCopy()
        {
            return (RegularEmployee)this.MemberwiseClone();
        }
    }
}
