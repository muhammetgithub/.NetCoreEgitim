using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{//Detaylı anlatım için CategoryRepository bakınız.
    internal class BlogRepository : IBlogDal//IBlogDal İnterface Miras Aldık Ve Voidleri Dolduracağız 
    {
        //Detaylı anlatım için CategoryRepository bakınız.
        // İki yollu veri tabanına ulasma yolu var  biri using var c=new Context(); diğeri En basa Context c = new context();
        //Context Adını DAL>Concrete>Context.Cs Classından almaktadır. Veri tAbanı baglama işlemlerini ordan yaptık

        public void AddBlog(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {

            using var c = new Context();
                c.Remove(blog);
        }

        public Blog GetBlogId(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);//Blog Tablosunda id göre arama yap dedik
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();

            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);//girilen Blog parametreisini al dedik BLog sutununda guncelle
            c.SaveChanges();

        }
    }
}
