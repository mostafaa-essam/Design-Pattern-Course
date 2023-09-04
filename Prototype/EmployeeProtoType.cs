using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class EmployeeProtoType
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public abstract EmployeeProtoType ShallowCopy();

        public abstract EmployeeProtoType DeepCopy();

        public override string ToString()
        {
            return $"Id: {this.ID}" +
                    $"Nmae: {this.Name}" +
                    $"Address:{this.Address.City},{this.Address.StreetName},{this.Address.Building}";
        }

    }
}
