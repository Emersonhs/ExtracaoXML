using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.ModelosXML.Contrato;
using XML_v2.ModelosXML.Patente;
using XML_v2.ModelosXML.ProgramaComputador;

namespace XML_v2
{
    class Program
    {
        static void Main(string[] args)
        {


            DeserializerXML orquestrador = new DeserializerXML();
            // orquestrador.Orquestrar<revista>(); //DesenhoIndustrial

            // orquestrador.Orquestrar<Contrato>();
            //  Console.WriteLine("Desenho Industrial.txt PRONTO.");

            orquestrador.Deserializer<Patente>();
            Console.WriteLine("Patente.txt PRONTO.");

            //  orquestrador.Deserializer<ProgramaComputador>();
            //Console.WriteLine("Programa Computador.txt PRONTO.");

            Console.ReadKey();

        }
    }
}
