using EntityLayer.Concrate;//EntityLayer Katmanındaki Category Tablosuna Erişmek için eklenmesi Gerekiyor

namespace DataAccesLayer.Abstract
{

    //İnterFace olusturulma Sebebi:Kod temizliğidir Voidlere burda kod yazmak yerine Repository De yazıyoruz burada sadece voidleri tanımlıyoruz
    //Sadece kodun Voidlerini Olusturuyoruz
    //Category Tablosu için Yapılacak İşlemler
    //I Intercafe oldugunu anlamak için Başına koyarız Sondaki DAL ise DataAccesLayer geldiğini anlamak için

    //Burada tanımlanması gerekilen  4 temel Method var bunlardan 3 void diğer 2'si Biri list 
    //public interface ICategoryDal
    //{
    //    ////List<Category>    Tablo: bir entity vermemiz lazım şuan katogori Interface olusturgumuz ıcın Category verdik
    //    ////List<>   Bu bizim tüm Categoryler ielinde tutcak 
    //    //List<Category> ListAllCategory();  //ListAllCategory Metodunda Adını biz degisterebilirz Tum Categoryleri içinde tutacagız 
    //    ////List<Category> GETİRMK(); de  diye biliriz yani

    //    ////------------------------------------------------------------------------------------------------
    //    ////Bu method İse ID göre Değer getirecek burada id eşit olan veriyi bulmamız için kullanıcaz
    //    ////Ondada direk Bu Tablodaki ID Bul dicez 
    //    //Category GetById(int id);//ID göre AL diyeceğiz bu methoda ve id göre veri cekiceğiz

    //    ////Category Tablo:Dışarıdan Bir veri alacagımız için bir void olusturuyoruz ve bu void Category tablosunda Calışsın diyoruz  yanınada bir değişken
    //    ////Tanımlaması yapıyoruz ekleme  veritabanınıa ekleme işlemleri burada yapılacak
    //    //void AddCategory(Category category);

    //    ////Category Tablo:Dışarıdan Bir veri Sileceğimiz için bir void olusturuyoruz ve bu void Category tablosunda Calışsın diyoruz  yanınada bir değişken
    //    ////Tanımlaması yapıyoruz biz category diyelim ona   veritabanınıa Delete işlemleri burada yapılacak
    //    //void DeleteCategory(Category category);


    //    ////Category Tablo:Dışarıdan Bir güncellicez Sileceğimiz için bir void olusturuyoruz ve bu void Category tablosunda Calışsın diyoruz  yanınada bir değişken
    //    ////Tanımlaması yapıyoruz biz category diyelim ona   veritabanınıa Güncelleme işlemleri burada yapılacak
    //    //void UpdateCategory(Category category);

    //}
    public interface ICategoryDal:IGenericDal<Category>//Generic T olarak Tanımlı olan yere biz Hangi Tabloda işlem yapıyorsak onu yazıyoruz.
    {

    }
    }
