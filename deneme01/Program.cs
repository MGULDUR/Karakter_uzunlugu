using System;
using System.Text;

namespace deneme01
{
    class Program
    {
        static void Main(string[] args)
        {


            string isim="mustafa";


            Console.WriteLine(Encoding.Unicode.GetByteCount(isim));

        }
    }
}
