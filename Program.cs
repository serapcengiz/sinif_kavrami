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

            Calisan calisan1=new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.SoyAd="Kara";
            calisan1.No=234564;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Calisan calisan2=new Calisan();
            calisan2.Ad="Serap";
            calisan2.SoyAd="Cengiz";
            calisan2.No=2345644;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();


        }
    }
    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı {0}",Ad);
            Console.WriteLine("Çalışan Soyadı {0}",SoyAd);
            Console.WriteLine("Çalışan No {0}",No);
            Console.WriteLine("Çalışan Departman {0}",Departman);
        }
    }
}
