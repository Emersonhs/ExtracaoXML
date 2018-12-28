using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2
{
    public class MontarArquivoDistritoIndustrial : BaseMontarArquivo
    {
        public MontarArquivoDistritoIndustrial() : base(Constantes.Arquivos.DesenhoIndustrialSaida)
        {
        }

        public void MonatarAquivo(revista revista) 
        {
            arquivo.WriteLine("No " + revista.numero + " de " + revista.dataPublicacao);
            arquivo.WriteLine("|");
            arquivo.WriteLine("No " + revista.numero + " de " + revista.dataPublicacao);
            foreach (var ItemDespacho in revista.despacho)
            {
                arquivo.WriteLine("(Cd) " + ItemDespacho.codigo);
                foreach (var item in ItemDespacho.processopatente.Items)
                {
                   // arquivo.WriteLine("("+ item.ind);
                }
            }
            arquivo.Close();
        }
       
    }
}
