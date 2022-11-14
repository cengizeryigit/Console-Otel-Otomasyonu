using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CengizEryigitOdev1
{
    internal class Program
    {
        public static double hesap(int kisisayisi, int gunsayisi, int ucret)
        {
            double tutar, gunlukkisiucreti = 0;
            gunlukkisiucreti = kisisayisi * ucret;
            tutar = gunlukkisiucreti * gunsayisi;
            return tutar;
        }

        public static double yuzdehesapla(double ucret, double yuzde)
        {
            double sonuc = 0;
            sonuc = (ucret / 100) * yuzde;
            return sonuc;
        }

        public static double Ay(int odacesidi, int kisisayisi, int gunsayisi)
        {
            double aytutar = 0;
            Console.WriteLine("\nKalmak İstediğiniz Ayı Seçiniz...");
            Console.WriteLine("Haziran = 1, Temmuz = 2, Ağustos = 3");
            bool dongu = true;
            while (dongu)
            {
                Console.Write("Seçiminiz : ");
                int secilenay = Convert.ToInt32(Console.ReadLine());
                if (secilenay==1)
                {
                    Console.WriteLine("Haziran ayını seçtiniz...");
                    if (odacesidi==1)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 2000);
                        aytutar = aytutar - yuzdehesapla(aytutar, 4);
                        aytutar = aytutar + yuzdehesapla(aytutar, 8);
                        dongu = false;
                    }
                    if (odacesidi==2)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 500);
                        aytutar = aytutar - yuzdehesapla(aytutar, 4);
                        aytutar = aytutar + yuzdehesapla(aytutar, 8);
                        dongu = false;
                    }
                    if (odacesidi==3)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 1000);
                        aytutar = aytutar - yuzdehesapla(aytutar, 4);
                        aytutar = aytutar + yuzdehesapla(aytutar, 8);
                        dongu = false;
                    }

                }
                else if (secilenay == 2)
                {
                    Console.WriteLine("Temmuz ayını seçtiniz...");
                    if (odacesidi == 1)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 2500);
                        aytutar = aytutar + yuzdehesapla(aytutar, 18);
                        aytutar = aytutar + yuzdehesapla(aytutar, 2.5);
                        dongu = false;
                    }
                    if (odacesidi == 2)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 750);
                        aytutar = aytutar + yuzdehesapla(aytutar, 18);
                        aytutar = aytutar + yuzdehesapla(aytutar, 2.5);
                        dongu = false;
                    }
                    if (odacesidi == 3)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 1500);
                        aytutar = aytutar + yuzdehesapla(aytutar, 18);
                        aytutar = aytutar + yuzdehesapla(aytutar, 2.5); 
                        dongu = false;
                    }

                }
                else if (secilenay == 3)
                {
                    Console.WriteLine("Ağustos ayını seçtiniz...");
                    if (odacesidi == 1)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 3000);
                        aytutar = aytutar + yuzdehesapla(aytutar, 8);
                        aytutar = aytutar + yuzdehesapla(aytutar, 2.5);
                        aytutar = aytutar + yuzdehesapla(aytutar, 10);
                        dongu = false;
                    }
                    if (odacesidi == 2)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 1000);
                        aytutar = aytutar + yuzdehesapla(aytutar, 8);
                        aytutar = aytutar + yuzdehesapla(aytutar, 2.5);
                        aytutar = aytutar + yuzdehesapla(aytutar, 10);
                        dongu = false;
                    }
                    if (odacesidi == 3)
                    {
                        aytutar = hesap(kisisayisi, gunsayisi, 2000);
                        aytutar = aytutar + yuzdehesapla(aytutar, 8);
                        aytutar = aytutar + yuzdehesapla(aytutar, 2.5);
                        aytutar = aytutar + yuzdehesapla(aytutar, 10);
                        dongu = false;
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim Yaptınız...");
                }
            }
            Console.WriteLine();
            return aytutar;
        }

        public static double Yemek(int kisisayisi, int gunsayisi)
        {
            double yemektutar = 0;
            Console.WriteLine("Yemek Seçimi Yapınız... ");
            Console.WriteLine("Sadece Kahvaltı = 1, Sadece Öğlen Yemeği = 2, Sadece Akşam Yemeği = 3");
            Console.WriteLine("Kahvaltı ve Öğlen Yemeği = 4, Kahvaltı ve Akşam Yemeği = 5, Hepsi = 6, Hiçbiri = 0");
            
            bool dongu = true;
            while (dongu)
            {
                Console.Write("Seçiminiz : ");
                int yemeksecim = Convert.ToInt32(Console.ReadLine());
                switch (yemeksecim)
                {
                    case 1:
                        Console.WriteLine("Sadece Kahvaltı seçtiniz...");
                        yemektutar = hesap(kisisayisi, gunsayisi, 100);
                        dongu=false;
                        break;
                    case 2:
                        Console.WriteLine("Sadece Öğlen Yemeği seçtiniz...");
                        yemektutar = hesap(kisisayisi, gunsayisi, 100);
                        dongu = false;
                        break;
                    case 3:
                        Console.WriteLine("Sadece Akşam Yemeği seçtiniz...");
                        yemektutar = hesap(kisisayisi, gunsayisi, 100);
                        dongu = false;
                        break;
                    case 4:
                        Console.WriteLine("Kahvaltı ve Öğlen Yemeği seçtiniz...");
                        yemektutar = hesap(kisisayisi, gunsayisi, 250);
                        dongu = false;
                        break;
                    case 5:
                        Console.WriteLine("Kahvaltı ve Akşam Yemeği seçtiniz...");
                        yemektutar = hesap(kisisayisi, gunsayisi, 250);
                        dongu = false;
                        break;
                    case 6:
                        Console.WriteLine("Hepsini seçtiniz...");
                        yemektutar = hesap(kisisayisi, gunsayisi, 350);
                        dongu = false;
                        break;
                    case 0:
                        Console.WriteLine("Hiçbirini seçtiniz...");
                        dongu = false;
                        yemektutar = 0;
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız..");
                        break;
                }


            }
            return yemektutar;
        }

        public static double Ozellik(int odacesidi,int kisisayisi, int gunsayisi)
        {
            Console.WriteLine();
            double ozellikucret = 0;
            int termalsecim = 0; 
            if (odacesidi == 1)
            {
                Console.WriteLine("Eklemek istediğiniz özellik...");
                Console.WriteLine("Sauna = 1, Özel Havuz = 2, Hepsi = 3, Hiçbiri = 0");

                bool dongu = true;
                while (dongu)
                {
                    Console.Write("Seçiminiz : ");
                    int ozelliksecim = Convert.ToInt32(Console.ReadLine());

                    if (ozelliksecim == 1)
                    {
                        Console.WriteLine("Sadece Sauana seçtiniz...");
                        ozellikucret= hesap(kisisayisi, gunsayisi, 250);
                        dongu= false;
                    }
                    else if (ozelliksecim == 2)
                    {
                        Console.WriteLine("Sadece Özel Havuz seçtiniz...");
                        Console.WriteLine("Termal kaynaklardan yararlanmak istermisiniz?");
                        Console.WriteLine("Evet = 1, Hayır = 2,");
                        bool termaldongu = true;
                        while (termaldongu)
                        {
                            Console.Write("Seçiminiz : ");
                            termalsecim = Convert.ToInt32(Console.ReadLine());
                            if (termalsecim==1)
                            {
                                ozellikucret = hesap(kisisayisi, gunsayisi, 350);
                                ozellikucret = ozellikucret + yuzdehesapla(ozellikucret,2.5) + yuzdehesapla(ozellikucret,8.5);
                                termaldongu=false;
                            }
                            else if (termalsecim==2)
                            {
                                ozellikucret = hesap(kisisayisi, gunsayisi, 300);
                                ozellikucret = ozellikucret  + yuzdehesapla(ozellikucret,7.5);
                                termaldongu = false;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim yaptınız...");
                            }
                        }
                        dongu= false;
                    }
                    else if (ozelliksecim == 3)
                    {
                        Console.WriteLine("Hepsini seçtiniz...");
                        Console.WriteLine("Termal kaynaklardan yararlanmak istermisiniz?");
                        Console.WriteLine("Evet = 1, Hayır = 2,");
                        bool termaldongu = true;
                        while (termaldongu)
                        {
                            Console.Write("Seçiminiz : ");
                            termalsecim = Convert.ToInt32(Console.ReadLine());
                            if (termalsecim == 1)
                            {
                                ozellikucret = hesap(kisisayisi, gunsayisi, 600);
                                ozellikucret = ozellikucret + yuzdehesapla(ozellikucret, 2.5) + yuzdehesapla(ozellikucret, 8.5);
                                termaldongu = false;
                            }
                            else if (termalsecim == 2)
                            {
                                ozellikucret = hesap(kisisayisi, gunsayisi, 550);
                                ozellikucret = ozellikucret + yuzdehesapla(ozellikucret, 7.5);
                                termaldongu = false;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim yaptınız...");
                            }
                        }
                        dongu = false;
                    }
                    else if (ozelliksecim == 0)
                    {
                        ozellikucret = 0;
                        dongu = false;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim yaptınız...");
                    }

                }
            }
            else
            {
                Console.WriteLine("Malasef özelliklerden yararlanamazsınız, sadece kral odası yararlanabilir...");
            }
            return ozellikucret;
        }

        public static double Odeme(double aysonrasıucret, double yemeksonrasıucret, double ozelliksonrasıucret)
        {
            double odenecektutar = 0;
            double ayliktutar = 0;
            odenecektutar = aysonrasıucret + yemeksonrasıucret + ozelliksonrasıucret;
            Console.WriteLine("\n Ödeme Yöntemi Seçiniz...");
            Console.WriteLine("Peşin Ödeme = 1,  6 Ay Taksit = 2 ");
            Console.WriteLine("8 Ay Taksit = 3  12 Ay Taksit = 4 ");
            bool dongu = true;
            while (dongu)
            {
                Console.Write("Seçiminiz : ");
                int odemesecim = Convert.ToInt32(Console.ReadLine());
                if (odemesecim==1)
                {
                    Console.WriteLine("\nPeşin Ödeme Yöntemini Seçtiniz...");
                    Console.WriteLine("Otel Odası Ücretiniz : "+ aysonrasıucret);
                    Console.WriteLine("Yemek Ücretiniz : "+ yemeksonrasıucret);
                    Console.WriteLine("Özellik Ücretiniz : "+ ozelliksonrasıucret);
                    Console.WriteLine(aysonrasıucret+" + "+yemeksonrasıucret+" + "+ozelliksonrasıucret+" = "+odenecektutar);
                    dongu=false;
                }
                else if (odemesecim==2)
                {
                    Console.WriteLine("\n6 Ay Taksit Ödeme Yöntemini Seçtiniz...");
                    Console.WriteLine("Otel Odası Ücretiniz : " + aysonrasıucret);
                    Console.WriteLine("Yemek Ücretiniz : " + yemeksonrasıucret);
                    Console.WriteLine("Özellik Ücretiniz : " + ozelliksonrasıucret);
                    Console.WriteLine("\nTaksit öncesi toplamtutar");
                    Console.WriteLine(aysonrasıucret + " + " + yemeksonrasıucret + " + " + ozelliksonrasıucret + " = " + odenecektutar);
                    ayliktutar = odenecektutar / 6.0; 
                    ayliktutar = ayliktutar + yuzdehesapla(ayliktutar, 2);
                    odenecektutar = ayliktutar * 6.0;
                    Console.WriteLine("\nTaksit sonrası toplamtutar");
                    Console.WriteLine("Aylık ödemeniz : "+ayliktutar+" * 6  = "+odenecektutar);

                    dongu = false;
                }
                else if (odemesecim==3)
                {
                    Console.WriteLine("\n8 Ay Taksit Ödeme Yöntemini Seçtiniz...");
                    Console.WriteLine("Otel Odası Ücretiniz : " + aysonrasıucret);
                    Console.WriteLine("Yemek Ücretiniz : " + yemeksonrasıucret);
                    Console.WriteLine("Özellik Ücretiniz : " + ozelliksonrasıucret);
                    Console.WriteLine("\nTaksit öncesi toplamtutar");
                    Console.WriteLine(aysonrasıucret + " + " + yemeksonrasıucret + " + " + ozelliksonrasıucret + " = " + odenecektutar);
                    ayliktutar = odenecektutar / 8.0;
                    ayliktutar = ayliktutar + yuzdehesapla(ayliktutar, 2);
                    odenecektutar = ayliktutar * 8.0;
                    Console.WriteLine("\nTaksit sonrası toplamtutar");
                    Console.WriteLine("Aylık ödemeniz : " + ayliktutar + " * 8  = " + odenecektutar);
                    dongu = false;
                }
                else if (odemesecim==4)
                {
                    Console.WriteLine("\n12 Ay Taksit Ödeme Yöntemini Seçtiniz...");
                    Console.WriteLine("Otel Odası Ücretiniz : " + aysonrasıucret);
                    Console.WriteLine("Yemek Ücretiniz : " + yemeksonrasıucret);
                    Console.WriteLine("Özellik Ücretiniz : " + ozelliksonrasıucret);
                    Console.WriteLine("\nTaksit öncesi toplamtutar");
                    Console.WriteLine(aysonrasıucret + " + " + yemeksonrasıucret + " + " + ozelliksonrasıucret + " = " + odenecektutar);
                    ayliktutar = odenecektutar / 12.0;
                    ayliktutar = ayliktutar + yuzdehesapla(ayliktutar, 2);
                    odenecektutar = ayliktutar * 12.0;
                    Console.WriteLine("\nTaksit sonrası toplamtutar");
                    Console.WriteLine("Aylık ödemeniz : " + ayliktutar + " * 12  = " + odenecektutar);
                    dongu = false;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız...");
                }
            }

            return odenecektutar;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz Kalmak İstediğiniz Oda Türünü Seçiniz...");
            Console.WriteLine("Kral Odası = 1, Standart Oda = 2, Vip Oda = 3");

            int kisisayisi = 0;
            int gunsayisi=0;
            double aysonrasıucret = 0;
            double yemeksonrasıucret = 0;
            double ozelliksonrasıucret = 0;
            

            bool dongu = true;
            while (dongu)
            {
                Console.Write("Seçiminiz : ");
                int odacesidi = Convert.ToInt32(Console.ReadLine());
                switch (odacesidi)
                {
                    case 1:
                        Console.WriteLine("Kral Odasını Seçtiniz...");
                        Console.Write("Kaç kişi kalıcaksınız : ");
                        kisisayisi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kaç gün kalıcaksınız : ");
                        gunsayisi = Convert.ToInt32(Console.ReadLine());
                        aysonrasıucret = Ay(odacesidi, kisisayisi, gunsayisi);
                        yemeksonrasıucret = Yemek(kisisayisi, gunsayisi);
                        ozelliksonrasıucret= Ozellik(odacesidi, kisisayisi, gunsayisi);
                        Odeme(aysonrasıucret, yemeksonrasıucret, ozelliksonrasıucret);
                        dongu = false;
                        break;

                    case 2:
                        Console.WriteLine("Standart Odayı Seçtiniz...");
                        Console.Write("Kaç kişi kalıcaksınız : ");
                        kisisayisi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kaç gün kalıcaksınız : ");
                        gunsayisi = Convert.ToInt32(Console.ReadLine());
                        aysonrasıucret = Ay(odacesidi, kisisayisi, gunsayisi);
                        yemeksonrasıucret = Yemek(kisisayisi, gunsayisi);
                        ozelliksonrasıucret = Ozellik(odacesidi, kisisayisi, gunsayisi);
                        Odeme(aysonrasıucret, yemeksonrasıucret, ozelliksonrasıucret);
                        dongu = false;
                        break;

                    case 3:
                        Console.WriteLine("Vip Odasını Seçtiniz...");
                        Console.Write("Kaç kişi kalıcaksınız : ");
                        kisisayisi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kaç gün kalıcaksınız : ");
                        gunsayisi = Convert.ToInt32(Console.ReadLine());
                        aysonrasıucret = Ay(odacesidi, kisisayisi, gunsayisi);
                        yemeksonrasıucret = Yemek(kisisayisi, gunsayisi);
                        ozelliksonrasıucret = Ozellik(odacesidi, kisisayisi, gunsayisi);
                        Odeme(aysonrasıucret, yemeksonrasıucret, ozelliksonrasıucret);
                        dongu = false;
                        break;

                    default:
                        Console.WriteLine("Hatalı işlem Yaptınız");
                        break;
                }

            }
            Console.WriteLine("\nProgramdan Çıkılıyor...");
            Console.ReadKey();
        }
    }
}
