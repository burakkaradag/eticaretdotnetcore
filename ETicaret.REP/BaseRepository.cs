using ETicaret.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.REP
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly ETicaretContext _db;
        public BaseRepository(ETicaretContext db)
        {
            _db = db;
        }
        public void Add(T entity)
        {
            _db.Entry(entity).State = EntityState.Added;
        }

        public void Delete(T entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
        }

        public async Task<T> Find(int id)
        {
           return await Set().FindAsync(id);
        }

        public async Task<List<T>> ListAll()
        {
           return await Set().ToListAsync();
        }

        public async Task<bool> Save()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public DbSet<T> Set()
        {
          return _db.Set<T>();
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
