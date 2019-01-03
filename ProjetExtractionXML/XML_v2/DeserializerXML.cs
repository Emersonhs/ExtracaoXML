using System;
using System.IO;
using XML_v2.ModelosXML.Contrato;
using XML_v2.ModelosXML.DesenhoIndustrial;
using XML_v2.ModelosXML.Patente;
using XML_v2.ModelosXML.ProgramaComputador;
using static XML_v2.TestHarness;

namespace XML_v2
{
    public class DeserializerXML
    {

        Serializer ser = new Serializer();
        string xmlInputData = string.Empty;
        OrquestradorArquivo GerarArquivo = new OrquestradorArquivo();

        public void Deserializer<T>() where T : class
        {
            if (typeof(T).Name == typeof(DesenhoIndustrial).Name)
            {
                try
                {
                    xmlInputData = File.ReadAllText(Constantes.Arquivos.DesenhoIndustrial);
                    T Retorno = ser.Deserialize<T>(xmlInputData);
                    GerarArquivo.Gerar<T>(Retorno);
                    Console.WriteLine("Desenho Industrial.txt PRONTO.");
                }
                catch (Exception msg)
                {
                    Console.WriteLine("Arquivo XML DesenhoIndustrial não encontrado.", msg);
                }
            }
            else if (typeof(T).Name == typeof(Contrato).Name)
            {
                try
                {
                    xmlInputData = File.ReadAllText(Constantes.Arquivos.Contrato);
                    T Retorno = ser.Deserialize<T>(xmlInputData);
                    GerarArquivo.Gerar<T>(Retorno);
                    Console.WriteLine("Contrato.txt PRONTO.");

                }
                catch (Exception msg)
                {
                    Console.WriteLine("Arquivo XML Contrato não encontrado.", msg);
                }
            }
            else if (typeof(T).Name == typeof(Patente).Name)
            {
                try
                {
                    xmlInputData = File.ReadAllText(Constantes.Arquivos.Patente);
                    T Retorno = ser.Deserialize<T>(xmlInputData);
                    GerarArquivo.Gerar<T>(Retorno);
                    Console.WriteLine("Patente.txt PRONTO.");

                }
                catch (Exception msg)
                {
                    Console.WriteLine("Arquivo XML Patente não encontrado.", msg);
                }
            }
            else if (typeof(T).Name == typeof(ProgramaComputador).Name)
            {
                try
                {
                    xmlInputData = File.ReadAllText(Constantes.Arquivos.ProgramaComputador);
                    T Retorno = ser.Deserialize<T>(xmlInputData);
                    GerarArquivo.Gerar<T>(Retorno);
                    Console.WriteLine("Programa Computador.txt PRONTO.");

                }
                catch (Exception msg)
                {
                    Console.WriteLine("Arquivo XML Programa Computador não encontrado.", msg);
                }

            }
        }
    }
}
