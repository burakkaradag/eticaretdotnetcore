using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.REP
{
    public interface IBaseRepository<T> where T : class, new()
    {
        DbSet<T> Set();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<bool> Save();
        Task<T> Find(int id);
        Task<List<T>> ListAll();
    }
}
