using System.Collections.Generic;

namespace GreenLifeOrganicStore.Repositories
{

    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(string id);
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        void UpdateAll(List<T> entities);
    }
}
