using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Türkçe karakter desteği için
           
            #region Double Değişkenler

            // double number;
            // number = 4.85;
            // Console.WriteLine(number);
            
            
            
            // double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;   
            
            // Console.WriteLine("****** Fiyat listesi ******");
            // applePrice = 14.85;
            // orangePrice = 20.95;
            // strawberryPrice = 45;
            // potatoPrice = 9.74;
            // tomatoPrice = 6.88;

            // Console.WriteLine("Elma fiyatı: " + applePrice +' '+ '₺');    
            // Console.WriteLine("Portakal fiyatı: " + orangePrice +' '+ '₺');   
            // Console.WriteLine("Çilek fiyatı: " + strawberryPrice +' '+ '₺');  
            // Console.WriteLine("Patates fiyatı: " + potatoPrice +' '+ '₺');
            // Console.WriteLine("Domates fiyatı: " + tomatoPrice +' '+ '₺');

            // double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;     

            // appleGram = 1.245;
            // orangeGram = 2.650;
            // strawberryGram = 0.750;
            // potatoGram = 4.859;       
            // tomatoGram = 3.745;

            // double appleTotalPrice = applePrice * appleGram;
            // double orangeTotalPrice = orangePrice * orangeGram;
            // double strawberryTotalPrice = strawberryPrice * strawberryGram; 
            // double potatoTotalPrice = potatoPrice * potatoGram;
            // double tomatoTotalPrice = tomatoPrice * tomatoGram;

            // Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyat: " + applePrice  + " - Gramaj : " + appleGram + " - Toplam Tutar :" 
            // + appleTotalPrice); 
            // Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat: " + orangePrice  + " - Gramaj : " + orangeGram + " - Toplam Tutar :" 
            // + orangeTotalPrice);
            // Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat: " + strawberryPrice  + " - Gramaj : " + strawberryGram + " - Toplam Tutar :" 
            // + strawberryTotalPrice);
            // Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat: " + potatoPrice  + " - Gramaj : " + potatoGram + " - Toplam Tutar :" 
            // + potatoTotalPrice);  
            // Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat: " + tomatoPrice  + " - Gramaj : " + tomatoGram + " - Toplam Tutar :" 
            // + tomatoTotalPrice);  

            // double ShoppingtotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Alışveriş Toplam Tutar : " + ShoppingtotalPrice + " ₺");
            #endregion
            Console.WriteLine();
            #region char Değişkenler
            //ABCDEFG
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //CHAR '' İÇİNDE SADECE 1 KARAKTER TUTAR
            // char symbol;
            // symbol = 'a';
            // Console.WriteLine(symbol); 

            #endregion

             #region Klavyeden Veri Girişleri

            // Console.WriteLine("********* CSharp Hava Yolları yolcu Bilgisi *********");
            // Console.WriteLine();

            // string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, 
            // passengerIdentityNumber; 

            // Console.Write("Yolcu Adınızı Giriniz : ");
            // passengerName = Console.ReadLine();
            // Console.Write("Yolcu Soyadınızı Giriniz : ");
            // passengerSurname = Console.ReadLine();

            // Console.Write("Yolcu İlçenizi Giriniz : ");
            // passengerDistrict = Console.ReadLine();

            // Console.Write("Yolcu Şehir Giriniz : ");
            // passengerCity = Console.ReadLine();

            // Console.Write("Yolcu Yaşınızı Giriniz : ");
            // passengerAge = Console.ReadLine();

            // Console.Write("Yolcu Tc Kimlik Numaranızı Giriniz : "); 
            // passengerIdentityNumber = Console.ReadLine();

            // Console.WriteLine();
            // Console.WriteLine("-/--------------------------------------/-");
            // Console.WriteLine("Yolcu TC Kimlik No : " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname
            // + " - Yolcu İlçe / İL : " + passengerDistrict + " / " + passengerCity + " - Yolcu Yaş : " + passengerAge);  
            
            // Console.WriteLine("-/--------------------------------------/-");
            #endregion
                                  
            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            // int shoesPrice, computerPrice, chairPrice, tvPrice;
            // shoesPrice = 1000;
            // computerPrice = 20000;
            // chairPrice = 5000;
            // tvPrice = 12000;

            // int shoesCount, computerCount, chairCount, tvCount;

            // Console.Write("Lütfen Aldığınız Ayakabı Sayısını Giriniz :");
            // shoesCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz :");
            // computerCount = int.Parse(Console.ReadLine());
                
            // Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz :");
            // chairCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen Aldığınız TV Sayısını Giriniz :");
            // tvCount = int.Parse(Console.ReadLine());

            // int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice 
            // + chairCount * chairPrice + tvCount * tvPrice; 

            // Console.WriteLine();
            // Console.WriteLine();

            // Console.WriteLine("Ödemeniz Gereken Tutar : " + totalPrice +' ' + '₺');
             
            #endregion
           
            #region Klavyeden Ondalıklı Sayı İşlemleri
            // double exam1, exam2, exam3, result;

            // Console.Write("Lütfen 1. sınav notunuzu giriniz :");
            // exam1 = double.Parse(Console.ReadLine());

            // Console.Write("Lütfen 1. sınav notunuzu giriniz :");
            // exam2 = double.Parse(Console.ReadLine());

            // Console.Write("Lütfen 1. sınav notunuzu giriniz :");
            // exam3 = double.Parse(Console.ReadLine());

            // result = (exam1 + exam2 + exam3) / 3;

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Sınav Ortalamanız : " +  result);
            
            #endregion

            #region Klavyeden Karekter girişleri
            // char gender;
            // Console.Write("Lütfen Cinsiet Seçiniz: ");
            // gender = char.Parse(Console.ReadLine());

            // Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion
             Console.Read();
        }

    }
}