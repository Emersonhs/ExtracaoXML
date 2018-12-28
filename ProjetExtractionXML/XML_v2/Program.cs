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
            //DesenhosIndustriais_old ct = new DesenhosIndustriais_old();

            //ct.LerArquivo();

            OrquestradorTipos orquestrador = new OrquestradorTipos();
            orquestrador.Orquestrar<revista>();
            //DesenhosIndustriais_old di = new DesenhosIndustriais_old();

            //di.LerArquivo();

            Console.WriteLine("arquivo pronto");

            Console.ReadKey();
        }
    }
}
