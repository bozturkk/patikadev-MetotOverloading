using System;

namespace MetotOverloading // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler.
            //değer tipinin referans tip gibi çalışmasını sağlar.

            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("basarili");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Çevirme işlemi başarılı değil");
                
            }
            Metotlar metotlar = new Metotlar();
            metotlar.Toplam(1,2,out int toplam);
            Console.WriteLine(toplam);


            CalculatorManager calculatorManager = new CalculatorManager(); //metot overloading sayesinde, 2 sayi ve 3 sayi şeklinde toplama işlemi yapabildim.
            calculatorManager.Toplam(1,2);
            calculatorManager.Toplam(1,2,3);
        }

        class Metotlar
        {
            public void Toplam(int a, int b, out int toplam)
            {
                toplam = a + b;

            }
        }
        class CalculatorManager //metot overloading Metot adı, parametre sayısı, parametreye göre ayrıştırma işlemi sağlar.
        {
            public int Toplam (int a, int b)
            {
                return a + b;
            }
            public int Toplam (int a, int b,int c)
            {
                return a + b + c;
            }
        }
    }
}
