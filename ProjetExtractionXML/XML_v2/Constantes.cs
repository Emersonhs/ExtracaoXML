using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2
{
    public abstract class Constantes
    {
        public abstract class Tags
        {
            public const string Numero = "numero";
            public const string dataPublicacao = "dataPublicacao";
            public const string DesenhoIndustrial = "DesenhoIndustrial";
            public const string codigo = "codigo";
            public const string despacho = "despacho";
            public const string titulo = "titulo";
            }



        public abstract class Arquivos
        {
            public const string DesenhoIndustrial = "ArquivosXML/DesenhoIndustrial_2499.xml";
            public const string DesenhoIndustrialSaida = "Saida/Desenho_Industrial.txt";
            public const string Contrato = "ArquivosXML/Contratos_2503.xml";
            public const string ContratoSaida = "Saida/ContratoSaida_2503.txt";
            public const string Patente = "ArquivosXML/Patente_2500.xml";
            public const string PatenteSaida = "Saida/PatenteSaida.txt";
            public const string ProgramaComputador = "ArquivosXML/Programa_2503.xml";
            public const string ProgramaComputadorSaida = "Saida/ProgramaComputador_2503.txt";
        }
    }
}
