using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    //Burada Kullandığımız bir Entity (Kütüphane Yani DataBase) olmadığı için  genele baglıyabiliyoruz
    //T bizim değer aldığımız bir class Yani Entitylayer>Blog Gibi dusun buda bir tablo gibi oluyor 
    //Yani Biz ileride EntityFrameWork Klasörü içinde sorguları calıstır diyince tek tek AboutRepository, yada Commentrepository
    //Diye uğraşmayacağız  repositories Klasörü içinde Sadece Generic Repository kalıcak Diğer yazdıklarımızı ileride silicez

    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c =new Context();
        public void Delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);//T için deki İd değeri bul getir

        }

        public List<T> GetListAll()
        {
            return c.Set<T>().ToList();//Sete Bağlı olarak
        }

        public void Insert(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
