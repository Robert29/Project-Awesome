namespace ForecastingService.Logic
{
    public class LogicHelper
    {
        public static LogicException NotFound()
        {
            return NotFound(string.Empty);
        }

        public static LogicException NotFound(string message)
        {
            return new LogicException(LogicException.LogicErrorCode.NotFound, message);
        }

        public static LogicException BadRequest()
        {
            return BadRequest(string.Empty);
        }

        public static LogicException BadRequest(string message)
        {
            return new LogicException(LogicException.LogicErrorCode.BadRequest, message);
        }

        public static LogicException Conflict()
        {
            return new LogicException(LogicException.LogicErrorCode.Conflict, string.Empty);
        }

        public static LogicException Conflict(string message)
        {
            return new LogicException(LogicException.LogicErrorCode.Conflict, message);
        }
    }
}
