using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    //Yazarla alakalı ne işlem düşünüyorsak olmasını varsaıyorsak onları eklıyoruz bunlar veri tabanında olusturucaz Migration ile
    //Veri Tabanında Olustrcagımız Tabloları Tutarız
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }//her Yazarın ID olur
        public string WriterName { get; set; }//Adı Olur
        public string WriterAbout { get; set; }//Hakkında Kısmı olur
        public string WriterImage { get; set; }//Resmi Olur
        public string WriterMail { get; set; }//Kullanıcı adı olur
        public string WriterPassword { get; set; }// Şifresi Olur

        public bool WriterStatus { get; set; }//Aktif mi Pasif Mi  Deriz



    }
}
