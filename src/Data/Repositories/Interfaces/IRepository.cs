﻿using System.Linq.Expressions;

namespace GerenciadorDeTarefas.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllWithIncludesAsync(params Expression<Func<T, object>>[] includes);
        Task<T> GetByIdWithIncludesAsync(int id, params Expression<Func<T, object>>[] includes);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
