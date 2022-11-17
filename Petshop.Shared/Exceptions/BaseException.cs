using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Shared.Exceptions
{
    [Serializable]
    public abstract class BaseException : Exception
    {
        protected BaseException() { }   
    }
}
