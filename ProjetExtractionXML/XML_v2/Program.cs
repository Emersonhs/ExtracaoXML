﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.ModelosXML.Contrato;
using XML_v2.ModelosXML.DesenhoIndustrial;
using XML_v2.ModelosXML.Patente;
using XML_v2.ModelosXML.ProgramaComputador;

namespace XML_v2
{
    class Program
    {
        static void Main(string[] args)
        {


            DeserializerXML orquestrador = new DeserializerXML();

            //orquestrador.Deserializer<DesenhoIndustrial>();//DesenhoIndustrial

            //orquestrador.Deserializer<Contrato>();

            orquestrador.Deserializer<Patente>();

            //orquestrador.Deserializer<ProgramaComputador>();

            Console.ReadKey();

        }
    }
}
