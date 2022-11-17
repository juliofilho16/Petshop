using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Shared
{
    public class UseCaseRequest<T>
    {
        public UseCaseRequest()
        {
        }

        public UseCaseRequest(T? request)
        {
            RequestValue = request;
        }

        public T? RequestValue { get; set; }
    }
}
