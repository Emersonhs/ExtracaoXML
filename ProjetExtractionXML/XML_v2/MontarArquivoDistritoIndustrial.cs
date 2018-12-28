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
                if (ItemDespacho.processopatente != null)
                {
                    arquivo.WriteLine("(" + ItemDespacho.processopatente.numero.inid + ") " + ItemDespacho.processopatente.numero.Value);
                    if (ItemDespacho.processopatente.datadeposito != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.datadeposito.inid + ") " + ItemDespacho.processopatente.datadeposito.Value);
                }
                foreach (var item in ItemDespacho.processopatente.titularlista)
                    arquivo.WriteLine("(" + item.titular.inid + ") " + item.titular.nomecompleto + " (" + item.titular.endereco.pais.sigla + "/" + item.titular.endereco.uf + ") ");

                if (ItemDespacho.processopatente.inventorlista != null)
                {
                    var NovaLista = ItemDespacho.processopatente.inventorlista.GroupBy(O => O.inid).ToList();

                    if (NovaLista.Count > 1)
                    {
                        foreach (var item in NovaLista)
                        {
                            string StrInventor = string.Empty;
                            
                            var InventorList = ItemDespacho.processopatente.inventorlista.Where(o => o.inid == item.Key).ToList();
                            StrInventor += "(" + item.Key + ") ";
                            foreach (var inventor in InventorList)
                            {
                                StrInventor  += inventor.nomecompleto + "; ";
                            }

                        }
                    }
                    foreach (var item in ItemDespacho.processopatente.inventorlista)
                    {

                        arquivo.WriteLine("(" + item.inid + ") " + item.nomecompleto);
                    }
                }
                if (ItemDespacho.processopatente.procuradorlista != null)
                    foreach (var item in ItemDespacho.processopatente.procuradorlista)
                        arquivo.WriteLine("(" + item.procurador.inid + ") " + item.procurador.nomecompleto);
                if (ItemDespacho.comentario != null)
                    arquivo.WriteLine("(" + ItemDespacho.comentario.inid + ") " + ItemDespacho.comentario.Value);

            }
            arquivo.Close();
        }

    }
}
