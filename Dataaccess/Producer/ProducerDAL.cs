using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class ProducerDAL : IProducerDAL
    {
        QuanLyLinhKienDBContext db;
        public ProducerDAL()
        {
            db = new QuanLyLinhKienDBContext();
        }
        public List<Producer> GetAllProducer()
        {
            return db.Producers.ToList();
        }
    }
}
