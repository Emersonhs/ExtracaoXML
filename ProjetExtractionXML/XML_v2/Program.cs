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
            OrquestradorTipos orquestrador = new OrquestradorTipos();
            orquestrador.Orquestrar<DesenhoIndustrial>();
        }
    }
}
