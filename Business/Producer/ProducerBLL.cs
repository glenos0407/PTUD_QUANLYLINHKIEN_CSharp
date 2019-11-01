using Dataaccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProducerBLL
    {
        private readonly ProducerDAL dal;
        public ProducerBLL()
        {
            dal = new ProducerDAL();
        }

        public List<Producer> GetAllProducer()
        {
            return dal.GetAllProducer();
        }
    }
}
