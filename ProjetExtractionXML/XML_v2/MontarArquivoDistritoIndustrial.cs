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

        public void MonatarAquivo(DesenhoIndustrial revista)
        {
            arquivo.WriteLine("No " + revista.numero + " de " + revista.dataPublicacao);
            arquivo.WriteLine("|");
            arquivo.WriteLine("No " + revista.numero + " de " + revista.dataPublicacao);
            foreach (var ItemDespacho in revista.despacho)
            {
                arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString().Replace('.',','));
                if (ItemDespacho.processopatente != null)
                {
                    arquivo.WriteLine("(" + ItemDespacho.processopatente.numero.inid + ") " + ItemDespacho.processopatente.numero.Value);
                    if (ItemDespacho.processopatente.datadeposito != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.datadeposito.inid + ") " + ItemDespacho.processopatente.datadeposito.Value);
                }
                foreach (var item in ItemDespacho.processopatente.titularlista)
                {
                    string strEndereco = string.Empty;
                    strEndereco = "(" + item.titular.inid + ") " + item.titular.nomecompleto;
                    if (item.titular.endereco.pais.sigla != null)
                        strEndereco += " (" + item.titular.endereco.pais.sigla;
                    else
                    strEndereco += " ("; 
                    if (item.titular.endereco.uf != null)
                        strEndereco +="/" + item.titular.endereco.uf + ") ";
                    else
                        strEndereco += ") ";
                    arquivo.WriteLine(strEndereco);

                }

                if (ItemDespacho.processopatente.inventorlista != null)
                {
                    var NovaLista = ItemDespacho.processopatente.inventorlista.GroupBy(O => O.inid).ToList();
                    string StrInventor = string.Empty; ;
                    StrInventor = string.Empty;
                    foreach (var item in NovaLista)
                    {
                        var InventorList = ItemDespacho.processopatente.inventorlista.Where(o => o.inid == item.Key).ToList();
                        StrInventor += "(" + item.Key + ") ";
                        foreach (var inventor in InventorList)
                            StrInventor += inventor.nomecompleto + "; ";

                        arquivo.WriteLine(StrInventor.Substring(0, StrInventor.Trim().Length - 1));
                        StrInventor = string.Empty;
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
