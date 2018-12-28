using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            DesenhosIndustriais ct = new DesenhosIndustriais();

            ct.LerArquivo();


            DesenhosIndustriais di = new DesenhosIndustriais();

            di.LerArquivo();

            Console.WriteLine("arquivo pronto");

            Console.ReadKey();
        }
    }
}
