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
<<<<<<< HEAD
        {            
=======
        {
>>>>>>> a8656393ceaba9e4a8b21ff6a0f4b8e2bec14e01
            if (typeof(T).Name == typeof(revista).Name)
            {
                MontarArquivoDistritoIndustrial MontarArquivo = new MontarArquivoDistritoIndustrial();
                MontarArquivo.MonatarAquivo((revista)Dados);
<<<<<<< HEAD
            }           
           
        }      
=======
            }
            else if (typeof(T).Name == typeof(Contrato).Name)
            {
                MontarArquivoContrato MontarArquivo = new MontarArquivoContrato();
                MontarArquivo.MonatarAquivo((Contrato)Dados);
            }
        }
>>>>>>> a8656393ceaba9e4a8b21ff6a0f4b8e2bec14e01
    }
}
