using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.UseCase.Common
{
    public class UpdateRequestBase<T>
    {
        public int Id { get; set; }
        public T? ModelValue { get; set; }
    }
}
