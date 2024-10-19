using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {



        Soru1();
        Soru2();
        Soru3();
        Soru4();
        Soru5();
        Soru6();
        Soru7();
        BenDegerDondurmem();
        Soru9();
        Soru10();
        EnYasliKisi();
        EnBuyukSayi();
        IsimleriDegistir();
        TekMiCiftMi();
        GidilenYol();
        DaireninAlani();
        BuyukKucukHarf();
        BosluklariSil();




        static void Soru1()
        {
            Console.WriteLine("Merhaba\r\nNasýlsýn ?\r\nÝyiyim\r\nSen nasýlsýn ?");
        }

        static void Soru2()
        {
            string name = "Melisa";
            int yas = 23;
            Console.WriteLine(name + " " + yas);
        }

        static void Soru3()
        {
            Random sayi = new Random();
            int hedefsayi = sayi.Next(1, 300);
            Console.WriteLine(hedefsayi);
        }

        static void Soru4()
        {
            Random sayi = new Random();
            int hedefsayi = sayi.Next(1, 300);
            Console.WriteLine($"Rastgele Sayý: {hedefsayi}, 3'e bölümünden kalan: {hedefsayi % 3}");
        }

        static void Soru5()
        {
            Console.WriteLine("Kaç yaþýndasýnýz?");
            int yas1 = int.Parse(Console.ReadLine());
            Console.WriteLine(yas1);
            if (yas1 > 18)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }

        static void Soru6()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sen Vodafone gibi aný yaþarken, ben Turkcell gibi seni her yerde çekemem.");
            }
        }

        static void Soru7()
        {
            Console.Write("Ýlk ismi giriniz: ");
            string isim1 = Console.ReadLine();
            Console.Write("Ýkinci ismi giriniz: ");
            string isim2 = Console.ReadLine();
            string temp = isim1;
            isim1 = isim2;
            isim2 = temp;
            Console.WriteLine($"Ýsimler deðiþtirildi: {isim1}, {isim2}");
        }

        static void BenDegerDondurmem()
        {
            Console.WriteLine("Ben deðer döndürmem, benim bir karþýlýðým yok, beni deðiþkene atamaya çalýþma");
        }

        static void Soru9()
        {
            Console.Write("Birinci sayýyý girin: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Ýkinci sayýyý girin: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = Topla(sayi1, sayi2);
            Console.WriteLine("Toplam: " + sonuc);
        }

        static int Topla(int a, int b)
        {
            return a + b;
        }

        static void Soru10()
        {
            Console.Write("Bir bool deðeri girin (true/false): ");
            bool value = bool.Parse(Console.ReadLine());

            string result = GetStringFromBool(value);
            Console.WriteLine(result);
        }

        static string GetStringFromBool(bool value)
        {
            if (value)
            {
                return "Kullanýcý true girdi.";
            }
            else
            {
                return "Kullanýcý false girdi.";
            }
        }

        static void EnYasliKisi()
        {
            Console.Write("Birinci kiþinin yaþýný girin: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.Write("Ýkinci kiþinin yaþýný girin: ");
            int age2 = int.Parse(Console.ReadLine());

            Console.Write("Üçüncü kiþinin yaþýný girin: ");
            int age3 = int.Parse(Console.ReadLine());

            int oldestAge = GetOldestAge(age1, age2, age3);
            Console.WriteLine("En yaþlý kiþinin yaþý: " + oldestAge);
        }

        static int GetOldestAge(int age1, int age2, int age3)
        {
            return Math.Max(age1, Math.Max(age2, age3));
        }

        static void EnBuyukSayi()
        {
            List<int> numbers = new List<int>();
            string input;

            Console.WriteLine("Sayýlarý girin (bitirmek için 'q' tuþlayýn):");

            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Geçersiz giriþ, lütfen bir sayý girin.");
                }
            }

            if (numbers.Count > 0)
            {
                int maxNumber = GetMaxNumber(numbers);
                Console.WriteLine("En büyük sayý: " + maxNumber);
            }
            else
            {
                Console.WriteLine("Hiç sayý girilmedi.");
            }
        }

        static int GetMaxNumber(List<int> numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        static void IsimleriDegistir()
        {
            Console.Write("Ýlk ismi girin: ");
            string name1 = Console.ReadLine();

            Console.Write("Ýkinci ismi girin: ");
            string name2 = Console.ReadLine();

            SwapNames(ref name1, ref name2);

            Console.WriteLine("Ýsimler deðiþtirildi: " + name1 + " " + name2);
        }

        static void SwapNames(ref string name1, ref string name2)
        {
            string temp = name1;
            name1 = name2;
            name2 = temp;
        }

        static void TekMiCiftMi()
        {
            Console.Write("Bir sayý girin: ");
            int number = int.Parse(Console.ReadLine());

            bool isEven = IsEven(number);
            Console.WriteLine("Çift sayý mý: " + isEven);
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void GidilenYol()
        {
            Console.Write("Hýzý girin (km/saat): ");
            double speed = double.Parse(Console.ReadLine());

            Console.Write("Zamaný girin (saat): ");
            double time = double.Parse(Console.ReadLine());

            double distance = CalculateDistance(speed, time);
            Console.WriteLine("Gidilen yol: " + distance + " km");
        }

        static double CalculateDistance(double speed, double time)
        {
            return speed * time;
        }

        static void DaireninAlani()
        {
            Console.Write("Dairenin yarýçapýný girin: ");
            double radius = double.Parse(Console.ReadLine());

            double area = CalculateCircleArea(radius);
            Console.WriteLine("Dairenin alaný: " + area);
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static void BuyukKucukHarf()
        {
            string text = "Zaman bir GeRi SayIm";

            string upper = text.ToUpper();
            string lower = text.ToLower();

            Console.WriteLine("Büyük harf: " + upper);
            Console.WriteLine("Küçük harf: " + lower);
        }

        static void BosluklariSil()
        {
            string text = "    Selamlar   ";
            text = text.Trim();

            Console.WriteLine(text);
        }
    }
}
