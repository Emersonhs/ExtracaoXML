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
                    MontarArquivoDistritoIndustrial MontarArquivo = new MontarArquivoDistritoIndustrial();
                    MontarArquivo.MontarArquivo((revista)Dados);
                }
                else if (typeof(T).Name == typeof(Contrato).Name)
                {
                    MontarArquivoContrato MontarArquivo = new MontarArquivoContrato();
                    MontarArquivo.MontarAquivo((Contrato)Dados);
                }
                else if (typeof(T).Name == typeof(Patentes).Name)
                {
                    MontarArquivoPatentes MontarArquivo = new MontarArquivoPatentes();
                    MontarArquivo.MontarAquivo((Patentes)Dados);
                }
            }
        }
    }
}
