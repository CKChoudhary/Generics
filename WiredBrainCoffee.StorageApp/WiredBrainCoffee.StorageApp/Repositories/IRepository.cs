using System.Collections;
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{

    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

    public interface IRepository<T>: IReadRepository<T> where T :IEntity
    {
        void Add(T item);
        void Save();
        void Remove(T item);
    }
}