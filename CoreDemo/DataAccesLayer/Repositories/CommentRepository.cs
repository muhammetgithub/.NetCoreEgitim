using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        Context c = new Context();
        public void Delete(Comment t)
        {
            
        }

        public Comment GetById(int id)
        {

            return c.Comments.Find(id);
        }

        public List<Comment> GetListAll()
        {
            return c.Comments.ToList();
        }

        public void Insert(Comment t)
        {
        }

        public void Update(Comment t)
        {
            
        }
    }
}
