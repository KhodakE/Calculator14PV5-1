using Scram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minus
{
    class MyInput : Iinput
    {
        double number1;
        
        public string formatt
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public MyInput() {
           number1=Convert.ToDouble( Console.ReadLine());
        }
        public double get_number()
        {
            return number1;   
        }
    }
}
