using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class ErrorResponse
    {
    }

    public class ErrorResult : SingleQueryResult<ErrorResponse>
    {
        public ErrorResult()
        {
            Success = false;
        }
        public ErrorResult(string message)
        {
            Success = false;

            ErrorMessage = message;
        }
    }
}
