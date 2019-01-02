using System.Linq;
using XML_v2.Model.Patente;

namespace XML_v2
{
    public class MontarArquivoPatentes : BaseMontarArquivo
    {
        public MontarArquivoPatentes() : base(Constantes.Arquivos.PatenteSaida)
        {
        }


        /* ALTERAR DAQUI PRA BAIXO  ***************************************************/


        public void MontarArquivo(Patente patente)
        {
            arquivo.WriteLine("No " + patente.numero + " de " + patente.dataPublicacao);
            arquivo.WriteLine("|");
            arquivo.WriteLine("No " + patente.numero + " de " + patente.dataPublicacao);

            foreach (var ItemDespacho in patente.despacho)
            {

                if (ItemDespacho.titulo.Substring(0, 7) == "Recurso" || ItemDespacho.titulo == "Tome Conhecimento do Parecer Técnico" || ItemDespacho.titulo == "Exigência")
                {
                    arquivo.WriteLine("(Cd) PR - Recursos");
                    arquivo.WriteLine("(Di) DIRPA");
                }
               
                else if (ItemDespacho.codigo != null)
                {
                    arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString().Replace(',', '.'));
                }




                if (ItemDespacho.processopatente != null)
                {
                    arquivo.WriteLine("(" + ItemDespacho.processopatente.numero.inid + ") " + ItemDespacho.processopatente.numero.Value + " " + ItemDespacho.processopatente.numero.kindcode);

                    if(ItemDespacho.processopatente.)

                    if (ItemDespacho.processopatente.datadeposito != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.datadeposito.inid + ") " + ItemDespacho.processopatente.datadeposito.Value);
                    }

                    // if(ItemDespacho.processopatente.)

                    if (ItemDespacho.processopatente.divisaopedido != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.divisaopedido.inid + ") " + ItemDespacho.processopatente.divisaopedido.numero + " " + ItemDespacho.processopatente.divisaopedido.datadeposito);
                    }
                }

                if (ItemDespacho.processopatente.titularlista != null)
                {
                    foreach (var item in ItemDespacho.processopatente.titularlista)
                    {
                        string strEndereco = string.Empty;
                        strEndereco = "(" + item.titular.inid + ") " + item.titular.nomecompleto;

                        if (item.titular.endereco != null)
                        {

                            if (item.titular.endereco.pais != null && item.titular.endereco.pais.sigla != null)
                                strEndereco += " (" + item.titular.endereco.pais.sigla;
                            else
                                strEndereco += " (";
                            if (item.titular.endereco.uf != null)
                                strEndereco += "/" + item.titular.endereco.uf + ") ";
                            else
                                strEndereco += ") ";
                            arquivo.WriteLine(strEndereco);
                        }
                    }
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
                if (ItemDespacho.comentario != null)
                {
                    if (ItemDespacho.comentario.Value.ToString().Length >= 10 && ItemDespacho.comentario.Value.Substring(0, 10) == "Recorrente")
                    {
                        arquivo.WriteLine("(Re) O depositante.");
                        arquivo.WriteLine("(De) Decisão: " + ItemDespacho.comentario.Value.Substring(28));
                    }
                    else
                    {
                        arquivo.WriteLine("(" + ItemDespacho.comentario.inid + ") " + ItemDespacho.comentario.Value);
                    }
                }
            }
            arquivo.Close();
        }

    }
}
