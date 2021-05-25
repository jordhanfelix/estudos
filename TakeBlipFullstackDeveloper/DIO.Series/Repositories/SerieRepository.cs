using DIO.Series.Entities;
using DIO.Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Repositories
{
    public class SerieRepository : IRepository<Serie>
    {

        private List<Serie> series = new List<Serie>();

        public void DeleteById(int id)
        {
            series[id].Excluir();
        }

        public Serie GetById(int id)
        {
            return series[id];
        }

        public void Insert(Serie entity)
        {
            series.Add(entity);
        }

        public List<Serie> List()
        {
            return series;
        }

        public int NextId()
        {
            return series.Count;
        }

        public void Update(int id, Serie entity)
        {
            series[id] = entity;

        }
    }
}
