using Blog.DataAccess;
using Blog.Infrastructures.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Infrastructures.Concrete
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private BlogDbContext _db { get; }
        private readonly DbSet<T> _dbSet;

        public Repo(BlogDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(int count)
        {
            var list = await GetAll();
            return list.Take(count).ToList();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> GetById(string id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Save(T t)
        {
            await _db.AddAsync(t);
        }


        public async Task<(bool success, string message)> SaveContext()
        {
            try
            {
                await _db.SaveChangesAsync();
                return (true, "Commit to Database successful");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public void Update(T t)
        {
            _dbSet.Attach(t);
            _db.Entry(t).State = EntityState.Modified;
        }

        public async Task Delete(int id)
        {
            var t = await _dbSet.FindAsync(id);
            if (_db.Entry(t).State == EntityState.Detached)
            {
                _dbSet.Attach(t);
            }
            _dbSet.Remove(t);
        }

        public async Task Delete(string id)
        {
            var t = await _dbSet.FindAsync(id);
            if (_db.Entry(t).State == EntityState.Detached)
            {
                _dbSet.Attach(t);
            }
            _dbSet.Remove(t);
        }

        public void Delete(T t)
        {
            if (t != null)
            {
                if (_db.Entry(t).State == EntityState.Detached)
                {
                    _dbSet.Attach(t);
                }
                _dbSet.Remove(t);
            }
        }
        public async Task<bool> CheckAny(int id)
        {
            var t = await _dbSet.FindAsync(id);
            return t != null;
        }
    }
}
