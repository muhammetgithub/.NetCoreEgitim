using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    //yorumlar Hakkında ne olabilir diye düşünüp veri tabanına kaydediceğimiz alanları olusturuyoruz
    //Bunlar Veri tabanındaki Sutun kısımları olmaktadır o yuzden dıkkatli ilerlenmeli
    //Veri Tabanında Olustrcagımız Tabloları Tutarız
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }//Yourumu yazanın kullanıcı adı olur
        public string CommentTitle { get; set; }//Başlığı olur
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }//Yorum ne zaman yazıldı diye tutmamız gerekiyor
        public bool CommentStatus { get; set; }
        public int BlogID { get; set; }//2.Fk olarak Tanımlayacagımız için aynı turde bir Sutun tanımlıyoruz
        public Blog Blog { get; set; }//Buda Bize baglantı yolunu açıyor 
    }
}
