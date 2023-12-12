using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilderMVC.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);
        Task<bool> Edit(T entity);
        Task<bool> Delete(T entity);
        Task<T> Get(int id);
        Task<ICollection<T>> GetAll();
        

    }
}
