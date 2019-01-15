using ForecastingService.Logic.Interfaces;

namespace ForecastingService.Logic.Rules
{
    public abstract class CVRSConfigurationToolLogic<T> : IForecastingServiceLogic<T>
    {
        public abstract void ValidateRules(T entity);
    }
}
