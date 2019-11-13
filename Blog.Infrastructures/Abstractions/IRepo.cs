using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Infrastructures.Abstractions
{
    public interface IRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(int count);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> CheckAny(int id);
        Task<T> GetById(string id);
        Task Save(T t);
        void Update(T t);
        Task Delete(int t);
        Task Delete(string t);
        void Delete(T t);
        Task<(bool success, string message)> SaveContext();
    }
}
