using CrudRepo.Models;

namespace CrudRepo.Interfaces;

public interface IRepository<T> where T : CrudBaseElement
{
    Task<T> CreateAsync(T entity);
    Task<T> ReadAsync(T entity);
    Task<T> UpdateAsync(T entity); 
    Task DeleteAsync(T entity);
}
