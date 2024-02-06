using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {


        static void Main(string[] args)
        {
            degiskenler();  // ctrl+R+M  extract method kısayolu

            vatandas vatandas1 = new vatandas();

            SelamVer("Ayşe");
            SelamVer();

            int sonuc = topla(5, 10);

            //arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Elif";

            string[] ogrenciler = new string[3]; // stack:string[] ogrenciler tanımlaması bellekte değişken tanımlanır  
            ogrenciler[0] = "Elif";              //  heap: new string[3] ile bellekte alan tanımlandı ve 3 adet yer oluşturuldu
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Murat";
            ogrenciler = new string[4];         //referans tip -- yeni new string[] tanımlamasından sonra verilen değer alınır önceki değerler bellekten silinir
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "Bayburt", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";

            Console.WriteLine(sehirler2[0]);

            int s1 = 10;
            int s2 = 20;
            s2 = s1;  //değer tip --  int,double, bool değerleri stack alanında işlenir atama yapıldıktan sonra  yapılan değişiklikler atanan değeri etkilemez
            s1 = 30;



            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //********************************

            string[] dizi = new[] {"Eda","Seda"};
            string[] dizi2 = new string[dizi.Length + 1];
          
            dizi2[0] = dizi[0];
            dizi2[1] = dizi[1];
            dizi2[2] = "Nur";
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }
           //***********************************

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İzmir1" };
            yeniSehirler1.Add(item:"Adana1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1=new Person();
            person1.FirstName = "ELİF";
            person1.LastName = "MERCİMEK";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 10;



            PttManager pttManager = new PttManager(new Personmanager());
            pttManager.GiveMask(person1);

            Console.ReadLine();  // Console ekranında bir şey yazılması için bekler 
        }


        static void SelamVer(string isim="isimsiz")
        {
            //void geriye değer döndürmez
            Console.WriteLine("Merhaba "+isim);   //fonksiyon 
        }

        static int topla(int s1=20,int s2=30)
        {
            //geriye değer döndüren fonksiyon return kullanılır

            int sonuc = s1 + s2;
            Console.WriteLine("Toplam: "+ sonuc);
            return sonuc;
        }

        private static void degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000.5; // tutar bilgisi projenin ilerleyen zamanlarında database üzerinden alınır
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Elif";
            string soyad = "Mercimek";
            int dogumYili = 2004;
            long tcNo = 10000000000;


            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
        }
    }


    public class vatandas
    {
        public string Ad { get; set; }   //prop
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
