using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Shared
{
    public class UseCaseResponse<T> : IResponse
    {
        public bool Success { get; private set; }
        public string? ErrorMessage { get; private set; }
        public List<ErrorMessage>? ErrorsMessages { get; private set; }
        public T? Result { get; private set; }

        public UseCaseResponse<T> SetResult(T result)
        {
            ErrorMessage = null;
            ErrorsMessages = null;
            Result = result;
            Success = true;
            return this;
        }
        public UseCaseResponse<T> SetError(IResponse response)
        {
            ErrorMessage = response.ErrorMessage;
            ErrorsMessages = response.ErrorsMessages;
            Success = false;
            Result = default(T);

            return this;
        }
        public UseCaseResponse<T> SetError(string errorMessage, List<ErrorMessage>? errors = null)
        {
            ErrorMessage = errorMessage;
            ErrorsMessages = errors;
            Success = false;
            Result = default(T);

            return this;
        }

        public UseCaseResponse<T> SetInternalServerError(string errorMessage,List<ErrorMessage>? errors = null)
        {
            return SetError(errorMessage, errors);
        }
    }
    public interface IResponse
    {
        public bool Success { get; }
        public string ErrorMessage { get; }
        public List<ErrorMessage> ErrorsMessages { get; }
    }
}
