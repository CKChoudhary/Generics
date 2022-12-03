using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IRepository<T> where T :IEntity
    {
        T GetById(int id);
        void Add(T item);
        void Save();
        void Remove(T item);
    }
}