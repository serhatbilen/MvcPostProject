using BitirmeProjem.DataAccessLayer.Repository;
using BitirmeProjem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjem.BusinessLayer
{
    public class PostManager
    {
        Repository<Post> repopost = new Repository<Post>();
        public List<Post> GetPost()
        {
            return repopost.List();
        }
    }
}
