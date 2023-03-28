namespace Static_Sinif_Uyeler.Static_Sinif_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı   :{0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine("Çalışan sayısı   :{0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Arda","Güler","Satın Alma");
            Calisan calisan2 = new Calisan("Volkan","Demirel","IK");
            Console.WriteLine("Çalışan sayısı   :{0}",Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi Sonucu      :{0}",Islemler.Topla(100,200));
            Console.WriteLine("Toplama işlemi Sonucu      :{0}",Islemler.Cıkar(400,200));


            
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        

        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }


    }


    static class Islemler
    {
        public static long Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cıkar(int sayi1 , int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}