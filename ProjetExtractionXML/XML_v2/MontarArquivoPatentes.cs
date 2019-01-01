using System.Linq;
using XML_v2.Model;

namespace XML_v2
{
    public class MontarArquivoPatentes : BaseMontarArquivo
    {
        public MontarArquivoPatentes() : base(Constantes.Arquivos.Patente)
        {
        }


        /* ALTERAR DAQUI PRA BAIXO  ***************************************************/


        public void MontarArquivo(Patentes patente)
        {
            arquivo.WriteLine("No " + patente.numero + " de " + patente.dataPublicacao);
            arquivo.WriteLine("|");
            arquivo.WriteLine("No " + patente.numero + " de " + patente.dataPublicacao);

            foreach (var ItemDespacho in patente.despacho)
            {
                arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString());
                if (ItemDespacho.processopatente != null)
                {
                    arquivo.WriteLine("(" + ItemDespacho.processopatente.numero.inid + ") " + ItemDespacho.processopatente.numero.Value);
                    if (ItemDespacho.processopatente.datadeposito != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.datadeposito.inid + ") " + ItemDespacho.processopatente.datadeposito.Value);
                    }
                    if (ItemDespacho.processopatente.divisaopedido != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.numero.inid + ") " + ItemDespacho.processopatente.datadeposito.Value + " " + ItemDespacho.processopatente.numero.Value);
                    }
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
                        strEndereco += "/" + item.titular.endereco.uf + ") ";
                    else
                        strEndereco += ") ";
                    arquivo.WriteLine(strEndereco);

                }

                if (ItemDespacho.processopatente.Inventorlista != null)
                {
                    var NovaLista = ItemDespacho.processopatente.Inventorlista.GroupBy(O => O.inid).ToList();
                    string StrInventor = string.Empty; ;
                    StrInventor = string.Empty;
                    foreach (var item in NovaLista)
                    {
                        var InventorList = ItemDespacho.processopatente.Inventorlista.Where(o => o.inid == item.Key).ToList();
                        StrInventor += "(" + item.Key + ") ";
                        foreach (var inventor in InventorList)
                            StrInventor += inventor.nomecompleto + "; ";

                        arquivo.WriteLine(StrInventor.Substring(0, StrInventor.Trim().Length - 1));
                        StrInventor = string.Empty;
                    }
                }
               
            }
            arquivo.Close();
        }

    }
}
