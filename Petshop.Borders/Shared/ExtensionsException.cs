using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Shared
{
    public static class ExtensionsException
    {
        public static List<ErrorMessage>? GetInnerExceptionMessages(this Exception ex)
        {
            ex = ex.InnerException;
            if (ex == null)
                return null;

            List<ErrorMessage> errors = new List<ErrorMessage>();

            while (ex != null)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    errors.Add(new ErrorMessage(code: "", message: ex.Message));
                }

                ex = ex.InnerException;
            }

            return errors;
        }
    }
}
