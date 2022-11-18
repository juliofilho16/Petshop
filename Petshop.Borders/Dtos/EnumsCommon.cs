using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos
{
   public enum SituacaoPagamento
    {

        [Description("Quitado")]
        QUITADO = 1,
        [Description("Cancelado")]
        CANCELADO = 2,
        [Description("Pendente")]
        PENDENTE = 3,
    }
}
