using System;

namespace ForecastingService.Logic
{
    public class LogicException : Exception
    {
        public enum LogicErrorCode { BadRequest = 400, NotFound = 404, Conflict = 409, PreconditionFailed = 412 };

        public LogicErrorCode ErrorCode { get; private set; }
        public string ErrorMessage { get; private set; }

        public LogicException(LogicErrorCode errorCode)
            : base()
        {
            ErrorCode = errorCode;
        }

        public LogicException(LogicErrorCode errorCode, string errorMessage)
            : base(errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }
    }
}
