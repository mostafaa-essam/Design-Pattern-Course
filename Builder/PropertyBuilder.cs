using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{   
    //Builder or Broker
    public class PropertyBuilder
    {
        private Property _property = new();

        public void SetAddress(string address)
        {
            _property.Address = address;
        }
        public void SetType(string type)
        {
            _property.Type = type;  
        } 
        public void SetPrice(decimal price)
        { 
            _property.Price = price; 
        }
        public void WithPool(bool pool)
        {
            _property.Pool = pool;
        }
        public void WithBackYard(bool backyard)
        {
            _property.BackYard =backyard ;
        }
        public void WithPlayGround(bool playground)
        {
            _property.PlayGround = playground;
        }
        public void Reset()
        {
            _property = new();
        }
        public Property Build()
        {
            var property = _property;
            Reset();
            return property;
        }



    }
}
