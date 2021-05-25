using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T GetById(int id);
        void Insert(T entity);
        void DeleteById(int id);
        void Update(int id, T entity);
        int NextId();

    }
}
