using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Concrate;

namespace DataAccesLayer.Repositories
{
    public class AboutRepository : IAboutDal
    {
        Context c = new Context();//Veritabanı baglantısını sağlıyorum
        public void AddAbout(About about)
        {
            c.Add(about);
            c.SaveChanges();
        }

        public void DeleteAbout(About about)
        {
        c.Remove(about);
            c.SaveChanges();
        }

        public About GetIdAbout(int id)//bunu veriyi gezdirmek için elde tutuyoruz
        {
            return c.Abouts.Find(id);
        }

        public List<About> ListAllAbout()
        {
            return c.Abouts.ToList();
        }

        public void UpdateAbout(About about)
        {
            c.Update(about);
        }
    }
}
