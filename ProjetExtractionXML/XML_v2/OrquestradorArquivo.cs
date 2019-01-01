using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.Model;

namespace XML_v2
{
    public class OrquestradorArquivo
    {
        public void Gerar<T>(object Dados)
        {
            {
                if (typeof(T).Name == typeof(revista).Name)
                {
                    MontarArquivoDesenhoIndustrial MontarArquivo = new MontarArquivoDesenhoIndustrial();
                    MontarArquivo.MontarArquivo((revista)Dados);
                }
                else if (typeof(T).Name == typeof(Contrato).Name)
                {
                    MontarArquivoContrato MontarArquivo = new MontarArquivoContrato();
                    MontarArquivo.MontarArquivo((Contrato)Dados);
                }
                else if (typeof(T).Name == typeof(Patente).Name)
                {
                    MontarArquivoPatentes MontarArquivo = new MontarArquivoPatentes();
                    MontarArquivo.MontarArquivo((Patente)Dados);
                }
            }
        }
    }
}
