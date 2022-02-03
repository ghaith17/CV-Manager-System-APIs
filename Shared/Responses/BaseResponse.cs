using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Responses
{
    public class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
