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
      
        public void Orquestrar<T>() where T : class
        {
            xmlInputData = File.ReadAllText(Constantes.Arquivos.Contrato);
            T Retorno = ser.Deserialize<T>(xmlInputData);
<<<<<<< HEAD

            GerarArquivo.Gerar<revista>(Retorno);
           
=======
            GerarArquivo.Gerar<Contrato>(Retorno);
>>>>>>> a8656393ceaba9e4a8b21ff6a0f4b8e2bec14e01
        }
    }
}
