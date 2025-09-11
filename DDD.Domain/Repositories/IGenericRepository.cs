using DDD.Domain.ValueObjects;

namespace DDD.Domain.Repositories;

public interface IGenericRepository<T> where T : class
{
	Task<IReadOnlyList<T>> GetAll();
	Task<T> GetAsync(BaseId Id);
	Task AddAsync(T entity);
	Task UpdateAsync(T entity);
	Task DeleteAsync(T entity);
}
