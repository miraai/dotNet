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
            ck.AllKoalaNames();
            ck.CountKoalas();

            Console.ReadLine();
        }
    }
}