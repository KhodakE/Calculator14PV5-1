using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scram
{
    public interface IOperation
    {
        string Name { get; set; }
        double Result();
    }
}