using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.Model;
using XML_v2.Model.Contrato;

namespace XML_v2
{
    class Program
    {
        static void Main(string[] args)
        {


            OrquestradorTipos orquestrador = new OrquestradorTipos();
           // orquestrador.Orquestrar<revista>(); //DesenhoIndustrial

            orquestrador.Orquestrar<Contrato>();
            Console.WriteLine("Desenho Industrial.txt PRONTO.");

            // orquestrador.Orquestrar<Patente>();

            // orquestrador.Orquestrar<ProgramaComputador>();


            //Console.ReadKey();

        }
    }
}
