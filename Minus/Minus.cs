using Scram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minus
{
    public abstract class Minus : IOperation, IOperationExeption
    {
       
        public string discription
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

        public string Name
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

        public string type
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
        MyInput num;
        MyInput num2;
       
        public double Result()
        {

            return num.get_number() - num2.get_number();
        }
    }
}
