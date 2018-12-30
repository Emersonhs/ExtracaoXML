using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2
{
    public class OrquestradorArquivo
    {
        public void Gerar<T>(object Dados)
        {            
            if (typeof(T).Name == typeof(DesenhoIndustrial).Name)
            {
                MontarArquivoDistritoIndustrial MontarArquivo = new MontarArquivoDistritoIndustrial();
                MontarArquivo.MonatarAquivo((DesenhoIndustrial)Dados);
            }           
           
        }      
    }
}
