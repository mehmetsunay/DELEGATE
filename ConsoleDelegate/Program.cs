using System;

namespace ConsoleDelegate
{
    class Program
    {

        /*
         Delegateler bir nevi metod pointerlarıdır
         Yani onları yönetirler 
         Delegete tipinden bir nesne türetip rahatlıkla işlemler yapabilmemizi sağlarlar
         ..................................................................

        Aşağıdaki örnekte  çevre ve alan hesabı yapan metodlarımı , ana metodum içerisinde delegeteden
       nesne turetip parametre geçirerek kullandım ...
        Ayrıca Delegetın parametresi içindeki değişkenlerinde aşağıdakilerle aynı olma zorunluluğu yoktur. 
        
         */

        delegate double Dikdortgen(double x, double y);
        static void Main(string[] args)
        {
            Dikdortgen test = new Dikdortgen(alan);
            Console.WriteLine(test(3, 8));
            Console.ReadLine();

        }
        static double cevre(double a,double b)
        {

            return 2 * (a + b);

        }

        static double alan(double a ,double b)
        {

            return a * b;

        }

      



    }
}
