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
            if (typeof(T).Name == typeof(revista).Name)
            {
                xmlInputData = File.ReadAllText(Constantes.Arquivos.DesenhoIndustrial);
                T Retorno = ser.Deserialize<T>(xmlInputData);
                GerarArquivo.Gerar<T>(Retorno);
            }
            else if (typeof(T).Name == typeof(Contrato).Name)
            {
                xmlInputData = File.ReadAllText(Constantes.Arquivos.Contrato);
                T Retorno = ser.Deserialize<T>(xmlInputData);
                GerarArquivo.Gerar<T>(Retorno);
            }
            else if (typeof(T).Name == typeof(Patentes).Name)
            {
                xmlInputData = File.ReadAllText(Constantes.Arquivos.Patente);
                T Retorno = ser.Deserialize<T>(xmlInputData);
                GerarArquivo.Gerar<T>(Retorno);
            }
            else if (typeof(T).Name == typeof(ProgramaComputador).Name)
            {
                xmlInputData = File.ReadAllText(Constantes.Arquivos.ProgramaComputador);
                T Retorno = ser.Deserialize<T>(xmlInputData);
                GerarArquivo.Gerar<T>(Retorno);
            }
        }
    }
}
