using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    //Blog'un neleri olur diiyp düşünüyoruz ve olusturmaya başlıyoruz
    //Bunlar Veri tabanındaki Sutun kısımları olmaktadır o yuzden dıkkatli ilerlenmeli
    //Veri Tabanında Olustrcagımız Tabloları Tutarız
    public class Blog
    {

        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumnailImage { get; set; }//Blog'un kucuk resmi
        public string BlogImage { get; set; }//Blogun Buyuk resminin yolunu tutcaz burada
        public DateTime BlogCreateDate { get; set; }
        public bool  BlogStatus { get; set; }
        public int CategoryID { get; set; }//FK anahtar olarak Tanımlanıyoruz Bu şekilde yeterli Category.CS De BlogID ekleniyor
        public Category Category { get; set; }//2.FK Anahtar kurmak arasında ilişki sağlamak için kruuyoruz Categoriyede BLOGID tanımlıyoruz
        public List<Comment> Comments { get; set; }//bir Bloga Birden Fazla yorum ile baglantılı olabilir Bundan dolayı List İçinde FK tutuyoruz
        


    }
}
