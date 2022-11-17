using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Concrate;//VeriTabanı Class Baglantısı bu dosyada oldugu ıcın eklıyoruz

namespace DataAccesLayer.Repositories
{
    public class WriterResponsitory : IWriterDal
    {
        Context c = new Context();
        public void AddWriter(Writer writer)
        {
           c.Add(writer); c.SaveChanges();
        }

        public void DeleteWriter(Writer writer)
        {
            c.Remove(writer); c.SaveChanges();
        }

        public Writer GetIdWriter(int id)
        {
            return c.Writers.Find(id);
            c.SaveChanges();
        }

        public List<Writer> ListAllWriter()
        {
            return c.Writers.ToList();
            c.SaveChanges();
        }

        public void UpdateWriter(Writer writer)
        {
            c.Update(writer);
            c.SaveChanges();
        }
    }
}
