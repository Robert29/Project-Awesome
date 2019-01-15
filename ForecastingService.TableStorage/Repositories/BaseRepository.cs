using ForecastingService.Logic.Interfaces;
using ForecastingService.TableStorage.Models;
using System.Threading.Tasks;

namespace ForecastingService.TableStorage.Repositories
{
    public class BaseRepository<T> : IForecastingServiceRepository<T> where T : IEntityWithId
    {
        public virtual Task<T> Get(string accountName, string accountKey, string tableName, string partitionKey, string rowKey)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<T> Insert(string accountName, string accountKey, string tableName, string partitionKey, T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
