using System.Threading.Tasks;

namespace ForecastingService.Logic.Interfaces
{
    public interface IForecastingServiceRepository<T>
    {
        Task<T> Get(string accountName, string accountKey, string tableName, string partitionKey, string rowKey);

        Task<T> Insert(string accountName, string accountKey, string tableName, string partitionKey, T entity);
    }
}
