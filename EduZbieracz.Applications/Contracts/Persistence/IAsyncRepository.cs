namespace EduZbieracz.Applications.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AdddAsync(T entity);
        Task UpdatedAsync(T entity);
        Task DeleteAsync(T entity);
    }
}