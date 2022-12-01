using System;
namespace arayuzler_ornek
{
    class Program
    {
        static void Main (string[]args)
        {
            Mustang mustang=new Mustang();
            Console.WriteLine(mustang.HangiMarkaninAraci().ToString());
            Console.WriteLine(mustang.KacTekerlerktenOlusur());
            Console.WriteLine(mustang.StandartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlerktenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Corolla corolla =new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlerktenOlusur());
            Console.WriteLine(corolla.StandartRengiNe().ToString());
            
        }
    }
}