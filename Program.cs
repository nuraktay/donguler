namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        { //Ekrandan girilen sayiya kadar olan tek sayilarini yazdır.
           /* Console.WriteLine("Lütfen bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {   
                if(i%2 == 1)
                Console.WriteLine(i);
            }
            // 1-1000 arasındaki tek ve çift sayıların ayrı ayrı top. yazdır
            int tektoplam =0;
            int cifttoplam =0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1)
                    tektoplam += i; // tektoplam = tektoplam + i demek oluyor.
                else
                    cifttoplam += i; // cifttoplam = cifttoplam + i demek oluyor.
            }
            Console.WriteLine("Tek Toplam:" + tektoplam);
            Console.WriteLine("Çift Toplam:" + cifttoplam); */

            /* break, continue: Döngüyü sonlandırmak için break, şarta bağlı mevcut döngünün o kısmını 
            istiyorsanız mesela 0-10 kadar gidiyor 9'u atlamamız isteniyor continue kullanılır. */
            
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
                
            }
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
                
            }





        }  

    }
}