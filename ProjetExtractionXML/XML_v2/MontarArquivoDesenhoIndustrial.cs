using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2
{
    public class MontarArquivoDesenhoIndustrial : BaseMontarArquivo
    {
        public MontarArquivoDesenhoIndustrial() : base(Constantes.Arquivos.DesenhoIndustrialSaida)
        {
        }

        public void MontarArquivo(revista revista)
        {
            arquivo.WriteLine("No " + revista.numero + " de " + revista.dataPublicacao);
            arquivo.WriteLine("|");
            arquivo.WriteLine("No " + revista.numero + " de " + revista.dataPublicacao);
            foreach (var ItemDespacho in revista.despacho)
            {

                if (ItemDespacho.processopatente != null)
                {
                    if (ItemDespacho.processopatente.complementofigurarosto != null)
                        if (ItemDespacho.processopatente.complementofigurarosto.inid == "fg")
                            arquivo.WriteLine("@FIG");

                    if (ItemDespacho.titulo.Substring(0, 7) == "Recurso")
                    {
                        arquivo.WriteLine("(Cd) PR - Nulidades");
                        arquivo.WriteLine("(Di) Desenho Industrial");
                    }
                    else
                    {
                        arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString().Replace(',', '.'));
                    }
                    arquivo.WriteLine("(" + ItemDespacho.processopatente.numero.inid + ") " + ItemDespacho.processopatente.numero.Value);
                    if (ItemDespacho.processopatente.datadeposito != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.datadeposito.inid + ") " + ItemDespacho.processopatente.datadeposito.Value);

                    if (ItemDespacho.processopatente.dataregistroprorrogacao != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.dataregistroprorrogacao.inid + ") " + ItemDespacho.processopatente.dataregistroprorrogacao.Value);

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
                    if (ItemDespacho.processopatente.publicacaonacional != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.publicacaonacional.inid + ") " + ItemDespacho.processopatente.publicacaonacional.datarpi);

                    if (ItemDespacho.processopatente.concessao != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.concessao.inid + ") " + ItemDespacho.processopatente.concessao.data);

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

                    }

                    if (ItemDespacho.processopatente.titulo != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.titulo.inid + ") " + ItemDespacho.processopatente.titulo.Value);

                    if (ItemDespacho.processopatente.divisaopedido != null)
                        arquivo.WriteLine("(" + ItemDespacho.processopatente.divisaopedido.inid + ") "
                            + ItemDespacho.processopatente.divisaopedido.numero + " " + ItemDespacho.processopatente.divisaopedido.datadeposito);

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
                                try
                                {
                                    if (Titular.endereco.pais.sigla != null)
                                        StrTilular += " (" + Titular.endereco.pais.sigla;
                                    else
                                        StrTilular += " (";
                                    if (Titular.endereco.uf != null)
                                        StrTilular += "/" + Titular.endereco.uf + ") ";
                                    else
                                        StrTilular += ") ";
                                    StrTilular += "; ";
                                }
                                catch { }
                            }
                            arquivo.WriteLine(StrTilular.Substring(0, StrTilular.Trim().Length - 1));
                            StrTilular = string.Empty;
                        }

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
                        {
                            var NovaLista = ItemDespacho.processopatente.procuradorlista.GroupBy(O => O.procurador.inid).ToList();
                            string StrProcurador = string.Empty; ;
                            StrProcurador = string.Empty;
                            foreach (var itemNovo in NovaLista)
                            {
                                if (ItemDespacho.processopatente.procuradorlista != null)
                                {
                                    var ProcuradorList = ItemDespacho.processopatente.procuradorlista.Where(o => o.procurador.inid == itemNovo.Key).ToList();
                                    StrProcurador += "(" + itemNovo.Key + ") ";
                                    foreach (var Procurador in ProcuradorList)
                                        StrProcurador += Procurador.procurador.nomecompleto + "; ";
                                    arquivo.WriteLine(StrProcurador.Substring(0, StrProcurador.Trim().Length - 1));
                                    StrProcurador = string.Empty;
                                }
                            }
                        }
                }
                if (ItemDespacho.comentario != null)
                    arquivo.WriteLine("(" + ItemDespacho.comentario.inid + ") " + ItemDespacho.comentario.Value);

            }
            arquivo.Close();
        }
    }


}
