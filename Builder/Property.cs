using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   //Product 
    public class Property
    {
        public string Address { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public bool Pool { get; set; }

        public  bool Parking { get; set; }

        public bool  PlayGround { get; set; }

        public bool BackYard { get; set; }

        public override string ToString()
        {
            return $"Address:{this.Address}" +"\n"+
                $"Type:{this.Type}"+"\n" +
                $"Price:${this.Price}"+"\n" +
                $"Pool:{this.Pool}"+"\n" +
                $"PlayGround:{this.PlayGround}"+"\n" +
                $"Backyard:{this.BackYard }"
                ;
        }

    }
}
