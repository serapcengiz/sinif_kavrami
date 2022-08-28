using System;
namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizisi
            //class SinifAdi
            //{
                //[Erişim Belirleyici] [Veri Tipi] Özellik Adı;
                //[Erişim Belirleyici] [Geri Dönüş tİPİ ] MetodAdı([parametre listesi])
                //{
                    //Metot Komutları
                //}
            //}
            //Erişim belirleyiciler
            //* Public
            //*Prrivate
            //*Internal
            //*Protected

            Calisan calisan1=new Calisan("Ayşe","Kara",234564,"İnsan Kaybakları");
            calisan1.CalisanBilgileri();

            Calisan calisan2=new Calisan();
            calisan2.Ad="Serap";
            calisan2.SoyAd="Cengiz";
            calisan2.No=2345644;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();

            Calisan calisan3=new Calisan("Serap","Cengiz");
            calisan3.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad,int no,string departman)
        {
            this.Ad=ad;
            this.SoyAd=soyad;
            this.No=no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad=ad;
            this.SoyAd=soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı {0}",Ad);
            Console.WriteLine("Çalışan Soyadı {0}",SoyAd);
            Console.WriteLine("Çalışan No {0}",No);
            Console.WriteLine("Çalışan Departman {0}",Departman);
        }
    }
}
