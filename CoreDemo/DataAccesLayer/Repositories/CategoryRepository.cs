using DataAccesLayer.Abstract;//İnterFace Bu klasörün altında bulunduğundan dolayı eklenıyor
using DataAccesLayer.Concrate;//Veri Tabanı Baglantı işlemleri bu kütüphanede bulunuyor
using EntityLayer.Concrate;//Veritabanı Tablolarına Erişimi için buradaki klasörün altında bulnuyor
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{

    //Buradaki Yapı Abstract Da oluşturdugumuz İnterface Crud Voidleri için Kod yazdığımız alan  
    //Burada Miras mantığı ile Çalışırız :IcategoryDal miras olarak al dedik ve içindeki voidleri kullan dedik
    //Bir İnterface Değer alıyorsanız İligli Class içine implement etmeniz gerekli yanı eklemeniz lazım
    //Buradaki tüm işlemler Abstract Daki İnterface den çalışıyor

    public class CategoryRepository : ICategoryDal//:Miras Aldık Ordaki Voidlere Erişebilmek için 
    {
        //Buradaki AddCategory Metodu :ICategory İnterface den miras  gelmektedir implement edilmiştir 

        //Veritabanına yansıttığım tablolar DAL>Concerete>Context Classında olduğu için tabloları buraya çağırıyoruz
        //DataBase baglantısı gibi düşün bunu 
        Context c = new Context();
        public void AddCategory(Category category)//tanımladıgımız parametreyi Category tablosunda ekle dedik
        {
            c.Add(category);//C. Erişmek için kullandık Ve Add Metodu ekleme metodunu cağırıp (Void deki Dışardan gelen parametreyi al dedik)
            c.SaveChanges();//Database Kaydet
        }
        //Buradaki DeleteCategory Metodu :ICategory İnterface den miras  gelmektedir implement edilmiştir 
        public void DeleteCategory(Category category)//Category tablosunda  girilen değişkene göre sil dedik
        {
            c.Remove(category);//Veritabanında Girilen category sil
            c.SaveChanges();
        }
        //Buradaki AddCategory Metodu :ICategory İnterface den miras  gelmektedir implement edilmiştir 
        public Category GetById(int id)
        {
            return c.Categorys.Find(id);//Bu metodu çalıştırabilmek için önce id buluyoruz oda Category içinde girilen İd bul dedik
        }
        //Buradaki AddCategory Metodu :ICategory İnterface den miras  gelmektedir implement edilmiştir 
        public List<Category> ListAllCategory()
        {
            return c.Categorys.ToList();//Kategorileri Listele komutudur ToList();
        }
        //Buradaki AddCategory Metodu :ICategory İnterface den miras  gelmektedir implement edilmiştir 
        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
