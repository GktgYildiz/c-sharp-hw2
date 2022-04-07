using System;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Atama ve işlemli atama operatörleri******");
            // atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            
            y += 2;
            Console.WriteLine(y);
            
            y /= 1;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);


            Console.WriteLine("******Mantıksal operatörler******");
            //Mantıksal Operatörler

            // ||, &&, ! 
            bool isSuccess = true;
            bool isFail = false;

            if (isSuccess && isFail)
                Console.WriteLine("Perfect!"); //&& "Ve" demek xxx ve yyy karşılıyorsa perfect yaz
           
            if (isSuccess || isFail)
                Console.WriteLine("Great!"); // || (alt gr + tire) "or", "Veya" demek. ikisinden biri karşılıyorsa
                                             // great yaz.
            
            if (isSuccess && !isFail)
                Console.WriteLine("Fine!"); // başına ünlem koyarak tersini aldık. yani doğruysa yanlış al veya
                                            // yanlışsa doğru al. && koyarakta xxx ve yyynin tersi karşılıyorsa
                                            // Fine yaz.

            Console.WriteLine("******İlişkisel operatörler******");
            //ilişkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;             // a, b'den küçüktür. bunu true olarak sisteme işledik bool kullanarak
            Console.WriteLine(sonuc);
            
            sonuc = a > b;                  // a, b'den büyüktür --> false
            Console.WriteLine(sonuc);

            sonuc = a >= b;                 // a, b'den büyük eşittir --> false
            Console.WriteLine(sonuc);
            
            sonuc = a <= b;                 // a, b'den küçük eşittir --> true
            Console.WriteLine(sonuc);
            
            sonuc = a == b;                 // a, b'ye eşittir --> false
            Console.WriteLine(sonuc);
            
            sonuc = a != b;                 // a, b'ye eşit değildir -->true
            Console.WriteLine(sonuc);

            Console.WriteLine("******Aritmetik operatörler******");

            //Aritmetik operatörler
            // /,*,+,-

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 =sayi1++;
            Console.WriteLine(sonuc1);

            // % : mod alır bölme işleminde kalanı verir
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);  


        }
    }
}
