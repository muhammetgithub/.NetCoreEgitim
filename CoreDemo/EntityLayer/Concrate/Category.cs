using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{//Bunlar Veri tabanındaki Sutun kısımları olmaktadır o yuzden dıkkatli ilerlenmeli
    //Veri Tabanında Olustrcagımız Tabloları Tutarız
    //Category Tablosunda Olması gereken sutunları ayarlamak için bu ekranı doldurmamız gerekli
    public class Category
    {
        //Prop Tanımlama mantığı Değişken türü isim {get set }
        [Key]
        public int CategoryID { get; set; }//Veri tabanınında olmaz ise olmaz ID
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }//Category Aktif ve ya pasife çekmemiz için durum değişkininde kontrol saglicaz
        public List<Blog> Blogs { get; set; }//Bir Kategoride Birden vazla Blog Ooldugundan dolayı List olarak tanımlıyoruz s



    }
}
