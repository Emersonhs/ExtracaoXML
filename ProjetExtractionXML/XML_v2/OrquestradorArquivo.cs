using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.Model;
using XML_v2.Model.Contrato;
using XML_v2.Model.DesenhoIndustrial;
using XML_v2.Model.Patente;

namespace XML_v2
{
    public class OrquestradorArquivo
    {
        public void Gerar<T>(object Dados)
        {
            {
                if (typeof(T).Name == typeof(DesenhoIndustrial).Name)
                {
                    MontarArquivoDesenhoIndustrial MontarArquivo = new MontarArquivoDesenhoIndustrial();
                    MontarArquivo.MontarArquivo((DesenhoIndustrial)Dados);
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
