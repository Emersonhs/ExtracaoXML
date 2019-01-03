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
                //if (ItemDespacho.titulo.Substring(0, 7) == "Recurso" || ItemDespacho.titulo == "Tome Conhecimento do Parecer Técnico" || ItemDespacho.titulo == "Exigência")
                //{
                //    arquivo.WriteLine("(Cd) PR - Recursos");
                //    arquivo.WriteLine("(Di) DIRPA");
                //}
                
                //else if (ItemDespacho.titulo == "Intimação para manifestação por parte do titular e do requerente")
                //{
                //    arquivo.WriteLine("(Cd) PR - Nulidades");
                //    arquivo.WriteLine("(Di) DIRPA");
                //}
                 if (ItemDespacho.codigo != null)
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


                    //classificação internacional
                    if (ItemDespacho.processopatente.classificacaointernacionallista != null)
                    {
                        var NovaLista = ItemDespacho.processopatente.classificacaointernacionallista.GroupBy(O => O.inid).ToList();
                        string StrClassificacao = string.Empty; ;
                        StrClassificacao = string.Empty;
                        foreach (var itemNovo in NovaLista)
                        {
                            if (ItemDespacho.processopatente.classificacaointernacionallista != null)
                            {
                                var PrioridadeList = ItemDespacho.processopatente.classificacaointernacionallista.Where(o => o.inid == itemNovo.Key).ToList();
                                StrClassificacao += "(" + itemNovo.Key + ") ";
                                foreach (var internacional in PrioridadeList)
                                    StrClassificacao += internacional.Value + " " + internacional.ano + ", ";
                                arquivo.WriteLine(StrClassificacao.Substring(0, StrClassificacao.Trim().Length - 1));
                                StrClassificacao = string.Empty;
                            }
                        }

                    }


                    //classificação nacional
                    if (ItemDespacho.processopatente.classificacaonacionallista != null)
                    {
                        var NovaLista = ItemDespacho.processopatente.classificacaonacionallista.GroupBy(O => O.inid).ToList();
                        string StrClassificacao = string.Empty; ;
                        StrClassificacao = string.Empty;
                        foreach (var itemNovo in NovaLista)
                        {
                            if (ItemDespacho.processopatente.classificacaonacionallista!= null)
                            {
                                var PrioridadeList = ItemDespacho.processopatente.classificacaonacionallista.Where(o => o.inid == itemNovo.Key).ToList();
                                StrClassificacao += "(" + itemNovo.Key + ") ";
                                foreach (var Nacional in PrioridadeList)
                                    StrClassificacao += Nacional.Value + ", ";
                                arquivo.WriteLine(StrClassificacao.Substring(0, StrClassificacao.Trim().Length - 1));
                                StrClassificacao = string.Empty;
                            }
                        }

                    }



                    //prioridade unionista começa depois dos trem internacional
                    if (ItemDespacho.processopatente.prioridadeunionistalista != null)
                    {
                        var NovaLista = ItemDespacho.processopatente.prioridadeunionistalista.GroupBy(O => O.inid).ToList();
                        string StrPrioridade = string.Empty; ;
                        StrPrioridade = string.Empty;
                        foreach (var itemNovo in NovaLista)
                        {
                            if (ItemDespacho.processopatente.prioridadeunionistalista != null)
                            {
                                var PrioridadeList = ItemDespacho.processopatente.prioridadeunionistalista.Where(o => o.inid == itemNovo.Key).ToList();
                                StrPrioridade += "(" + itemNovo.Key + ") ";
                                foreach (var Prioridade in PrioridadeList)
                                    StrPrioridade += Prioridade.dataprioridade.Value + " " + Prioridade.siglapais.Value + " " + Prioridade.numeroprioridade.Value + "; ";
                                arquivo.WriteLine(StrPrioridade.Substring(0, StrPrioridade.Trim().Length - 1));
                                StrPrioridade = string.Empty;
                            }
                        }
                    }
                    //prioridade unionista término ^^^^^^^^



                    //lista de inventores inventor
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

                    if (ItemDespacho.processopatente.datadeposito != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.datadeposito.inid + ") " 
                            + ItemDespacho.processopatente.datadeposito.Value);
                    }

                    // if(ItemDespacho.processopatente.)

                    if (ItemDespacho.processopatente.divisaopedido != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.divisaopedido.inid + ") " 
                            + ItemDespacho.processopatente.divisaopedido.numero + " " + ItemDespacho.processopatente.divisaopedido.datadeposito);
                    }



                    //dentro de despacho pode haver um atributo chamado título que vai antes da lista de titulares,
                    //a linha abaixo serve para colocar este título
                    if (ItemDespacho.titulo != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.titulo + ItemDespacho.titulo);
                    }


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




                    //if (ItemDespacho.processopatente.titularlista != null)
                    //{
                    //    foreach (var item in ItemDespacho.processopatente.titularlista)
                    //    {
                    //        string strEndereco = string.Empty;
                    //        strEndereco = "(" + item.inid + ") " + item.nomecompleto;

                    //        if (item.endereco != null)
                    //        {

                    //            if (item.endereco.pais != null && item.endereco.pais.sigla != null)
                    //                strEndereco += " (" + item.endereco.pais.sigla;
                    //            else
                    //                strEndereco += " (";
                    //            if (item.endereco.uf != null)
                    //                strEndereco += "/" + item.endereco.uf + ") ";
                    //            else
                    //                strEndereco += ") ";
                    //            arquivo.WriteLine(strEndereco);
                    //        }
                    //    }
                    //}

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
