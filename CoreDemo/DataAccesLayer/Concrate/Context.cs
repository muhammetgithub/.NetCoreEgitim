using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrate
{
    //Concrate Context Dosyası Database Tablolama İşlemleri için kullanılıyor
    //Bunlar Veri tabanı bağlanttısını olusturuyruz  hata oldugunda ,işlemez
    //Security SSL  hatası verirse  Encrypt=false eklememeiz laızm
    //Buradaki Tabloları Veritabanı SQL Aktarmamız için Tools>NuGet>Packmanage console çalıstırıız
    //Migration Komutlarını Yazarız. add-migration DenemE bu koddan sonra basarılı olusursa
    //Tabloları yukle demek için :  update-database komutunu calıstırırız ve database atmış oluruz
    public class Context:DbContext//Db Komutlarını kullanabilmemiz içni DBcontextden Miras alırız 
    {
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GOZ-PC-025;database=CoreBlogDb;integrated security=true;encrypt=false");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
