namespace ForecastingService.Logic.Interfaces
{
    public interface IForecastingServiceLogic<T>
    {
        void ValidateRules(T entity);
    }
}
