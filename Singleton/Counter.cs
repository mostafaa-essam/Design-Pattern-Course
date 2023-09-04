using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Counter
    {
        public int counter { get; set; }

        //2.Private static Field:-
        private static Counter instance =null;

        private static object Object =new object();

        //3.Method to return that private field
        public static Counter GetInstance()
        {
            //lock keyword for multithreading

            if (instance == null)//Dobule check
            {
                lock (Object)
                {
                    if (instance is null)
                    {
                        instance = new Counter();//Creating the instance
                    }

                }

            }
            return instance;
        }
        //1.Private Constructor
        private Counter()
        {
            
        }

        public int AddOne()
        {
            return counter++;
        }
    }
}
