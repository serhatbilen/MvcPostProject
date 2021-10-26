using BitirmeProjem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjem.DataAccessLayer.Repository
{
    public class RepositoryBase
    {
        protected static BitirmeProjemEntities db;
        private static object obje = new object();
        protected RepositoryBase()
        {
            CreateEntities();
        }
        private static void CreateEntities()
        {
            if (db == null)
            {
                lock (obje)
                {
                    db = new BitirmeProjemEntities();
                }

            }
        }
    }
}
