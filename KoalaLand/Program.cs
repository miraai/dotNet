using System;

namespace KoalaLand
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateKoalas ck = new CreateKoalas();
            ck.MakeKoalas();
            ck.ListKoalas();

            Console.ReadLine();
        }
    }
}