using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.Model;
using static XML_v2.TestHarness;

namespace XML_v2
{
    public class OrquestradorTipos
    {

        Serializer ser = new Serializer();
        string xmlInputData = string.Empty;
        OrquestradorArquivo GerarArquivo = new OrquestradorArquivo();

        public void OrquestrarRevista<T>() where T : class
        {

            xmlInputData = File.ReadAllText(Constantes.Arquivos.DesenhoIndustrial);
            T Retorno = ser.Deserialize<T>(xmlInputData);
            GerarArquivo.Gerar<revista>(Retorno);

        }


        public void OrquestrarContrato<T>() where T : class
        {
            xmlInputData = File.ReadAllText(Constantes.Arquivos.Contrato);
            T Retorno = ser.Deserialize<T>(xmlInputData);
            GerarArquivo.Gerar<Contrato>(Retorno);

        }
    }
}
