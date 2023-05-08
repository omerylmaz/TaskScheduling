using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Domain.ApiResult
{
    public class ApiResult<T>
    {
        public bool IsSuccess { get; set; }
        public List<string> Messages { get; set; } = new();
        public T Response { get; set; }

        public ApiResult<T> SetResponse(T response, string? message = null)
        {
            Response = response;
            IsSuccess = true;
            if (message != null)
            {
                Messages.Add(message);
            }

            return this;
        }

        public ApiResult<T> SetError(string errorMessage)
        {
            IsSuccess = false;
            Messages.Add(errorMessage);
            return this;
        }

        public ApiResult<T> SetError(List<string> messages)
        {
            IsSuccess = false;
            Messages.AddRange(messages);
            return this;
        }
    }
}
