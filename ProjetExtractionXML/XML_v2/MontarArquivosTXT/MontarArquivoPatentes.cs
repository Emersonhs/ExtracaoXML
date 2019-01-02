using System.Linq;
using XML_v2.ModelosXML.Patente;

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

                //verificações para o (Cd)
                if (ItemDespacho.titulo.Substring(0, 7) == "Recurso" || ItemDespacho.titulo == "Tome Conhecimento do Parecer Técnico" || ItemDespacho.titulo == "Exigência")
                {
                    arquivo.WriteLine("(Cd) PR - Recursos");
                    arquivo.WriteLine("(Di) DIRPA");
                }
                else if (ItemDespacho.titulo == "Intimação para manifestação por parte do titular e do requerente")
                {
                    arquivo.WriteLine("(Cd) PR - Nulidades");
                    arquivo.WriteLine("(Di) DIRPA");
                }
                else if (ItemDespacho.codigo != null)
                {
                    arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString().Replace(',', '.'));
                }




                if (ItemDespacho.processopatente != null)
                {
                    arquivo.WriteLine("(" + ItemDespacho.processopatente.numero.inid + ") " + ItemDespacho.processopatente.numero.Value + " " + ItemDespacho.processopatente.numero.kindcode);

                    //classificação internacional

                    if (ItemDespacho.processopatente.pedidointernacional != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.pedidointernacional.inid + ") " + ItemDespacho.processopatente.pedidointernacional.numeropct + " " + "de " + ItemDespacho.processopatente.pedidointernacional.datapct);
                    }

                    //   if (ItemDespacho.processopatente.)
                    /*
                    //classificação nacional
                    if (ItemDespacho.processopatente.classificacaonacionallista != null)
                    {
                        var NovaLista = ItemDespacho.processopatente.classificacaonacionallista.classificacaonacional.GroupBy(O => O.inid).ToList();
                        string StrClassificacao = string.Empty; ;
                        StrClassificacao = string.Empty;
                        foreach (var itemNovo in NovaLista)
                        {
                            if (ItemDespacho.processopatente.classificacaonacionallista != null)
                            {
                                var PrioridadeList = ItemDespacho.processopatente.classificacaonacionallista.classificacaonacional.Where(o => o.inid == itemNovo.Key).ToList();
                                StrClassificacao += "(" + itemNovo.Key + ") ";
                                foreach (var Nacional in PrioridadeList)
                                    StrClassificacao += Nacional.Value + ", ";
                                arquivo.WriteLine(StrClassificacao.Substring(0, StrClassificacao.Trim().Length - 1));
                                StrClassificacao = string.Empty;
                            }
                        }

                    }     */

                    /*
                    //prioridade unionista começa depois dos trem internacional
                    if (ItemDespacho.processopatente.Prioridadeunionistalista != null)
                    {
                        var NovaLista = ItemDespacho.processopatente.Prioridadeunionistalista.prioridadeunionista.GroupBy(O => O.inid).ToList();
                        string StrPrioridade = string.Empty; ;
                        StrPrioridade = string.Empty;
                        foreach (var itemNovo in NovaLista)
                        {
                            if (ItemDespacho.processopatente.Prioridadeunionistalista != null)
                            {
                                var PrioridadeList = ItemDespacho.processopatente.Prioridadeunionistalista.prioridadeunionista.Where(o => o.inid == itemNovo.Key).ToList();
                                StrPrioridade += "(" + itemNovo.Key + ") ";
                                foreach (var Prioridade in PrioridadeList)
                                    StrPrioridade += Prioridade.dataprioridade.Value + " " + Prioridade.siglapais.Value + " " + Prioridade.numeroprioridade.Value + "; ";
                                arquivo.WriteLine(StrPrioridade.Substring(0, StrPrioridade.Trim().Length - 1));
                                StrPrioridade = string.Empty;
                            }
                        }
                    }
                    //prioridade unionista término ^^^^^^^^
                    */


                    //lista de inventores inventor
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

                    if (ItemDespacho.processopatente.datadeposito != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.datadeposito.inid + ") " + ItemDespacho.processopatente.datadeposito.Value);
                    }

                    // if(ItemDespacho.processopatente.)

                    if (ItemDespacho.processopatente.divisaopedido != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.divisaopedido.inid + ") " + ItemDespacho.processopatente.divisaopedido.numero + " " + ItemDespacho.processopatente.divisaopedido.datadeposito);
                    }


                    /*

                    //lista de titulares
                    if (ItemDespacho.processopatente.titularlista != null)
                    {
                        var ListaInid = ItemDespacho.processopatente.titularlista.GroupBy(O => O.inid).ToList();
                        string StrTilular = string.Empty; ;
                        StrTilular = string.Empty;
                        foreach (var Inid in ListaInid)
                        {
                            var TitularList = ItemDespacho.processopatente.titularlista.Where(o => o.inid == Inid.Key).ToList();
                            StrTilular += "(" + Inid.Key + ") ";
                            foreach (var Titular in TitularList)
                            {
                                StrTilular += Titular.nomecompleto;

                                if (Titular.endereco != null)
                                {
                                    if (Titular.endereco.pais != null && Titular.endereco.pais.sigla != null)
                                        StrTilular += " (" + Titular.endereco.pais.sigla;
                                    else
                                        StrTilular += " (";
                                    if (Titular.endereco.uf != null)
                                        StrTilular += "/" + Titular.endereco.uf + ") ";
                                    else
                                        StrTilular += ") ";
                                    StrTilular += "; ";
                                }
                            }
                            arquivo.WriteLine(StrTilular.Substring(0, StrTilular.Trim().Length - 1));
                            StrTilular = string.Empty;
                        }

                    }

                    */


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
            }
            arquivo.Close();
        }

    }
}
