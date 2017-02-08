using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scram
{
    public interface IOperationExeption
    {
        string type { get; set; }
        string discription { get; set; }
    }
}