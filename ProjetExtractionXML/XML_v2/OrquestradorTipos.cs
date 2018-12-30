using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static XML_v2.TestHarness;

namespace XML_v2
{
    public class OrquestradorTipos
    {

        Serializer ser = new Serializer();
        string xmlInputData = string.Empty;
        OrquestradorArquivo GerarArquivo = new OrquestradorArquivo();
      
        public void Orquestrar<T>() where T : class
        {
            xmlInputData = File.ReadAllText(Constantes.Arquivos.DesenhoIndustrial);
            T Retorno = ser.Deserialize<T>(xmlInputData);
            GerarArquivo.Gerar<DesenhoIndustrial>(Retorno);
        }
    }
}
