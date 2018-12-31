using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2
{
    public class MontarArquivoProgramaComputador : BaseMontarArquivo

    {

        public MontarArquivoProgramaComputador() : base(Constantes.Arquivos.ProgramaComputadorSaida)
        {
        }

        public void MontarArquivo(ProgramaComputador programaComputador)
        {
            arquivo.WriteLine("No " + programaComputador.numero + " de " + programaComputador.dataPublicacao);

            foreach (var ItemDespacho in programaComputador.despacho)
            {
                arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString());
                if (ItemDespacho.processoprograma != null)
                {
                    arquivo.WriteLine("(" + ItemDespacho.processoprograma.numero.inid + ") " + ItemDespacho.processoprograma.numero.Value);
                    arquivo.WriteLine("(" + ItemDespacho.processoprograma.titulo.inid + ") " + ItemDespacho.processoprograma.titulo.Value);
                    arquivo.WriteLine("(" + ItemDespacho.processoprograma.dataCriacao.inid + ") " + ItemDespacho.processoprograma.dataCriacao.Value);
                }


                // ************************   TEM DE CONCATENAR QUANDO TIVER 2 NOMES IGUAIS - falta fazer


                if (ItemDespacho.processoprograma.campoAplicacaoLista != null)
                {
                    //lista dos criadores
                    foreach (var itemCriador in ItemDespacho.processoprograma.criadorLista)
                    {
                        arquivo.WriteLine("(" + itemCriador.inid + ") " + itemCriador.nome);
                    }

                    //lista das linguagens     
                    foreach (var itemLinguagem in ItemDespacho.processoprograma.linguagemLista)
                    {
                        arquivo.WriteLine("(" + itemLinguagem.inid + ") " + itemLinguagem.Value);
                    }


                    // ***************** ver se está certo

                    foreach (var itemCampoAplicacao in ItemDespacho.processoprograma.campoAplicacaoLista)
                    {
                        arquivo.WriteLine("(" + itemCampoAplicacao.codigo + ") " + itemCampoAplicacao.codigo.Value);
                    }

                    foreach (var itemTipoPrograma in ItemDespacho.processoprograma.tipoProgramaLista)
                    {
                        arquivo.WriteLine("(" + itemTipoPrograma.codigo + ") " + itemTipoPrograma.codigo.Value);
                    }

                }
                //foreach (var item in ItemDespacho.processoprograma.campoAplicacaoLista)
                //{
                //    string strEndereco = string.Empty;
                //    strEndereco = "(" + item.titular.inid + ") " + item.titular.nomecompleto;
                //    if (item.titular.endereco.pais.sigla != null)
                //        strEndereco += " (" + item.titular.endereco.pais.sigla;
                //    else
                //        strEndereco += " (";
                //    if (item.titular.endereco.uf != null)
                //        strEndereco += "/" + item.titular.endereco.uf + ") ";
                //    else
                //        strEndereco += ") ";
                //    arquivo.WriteLine(strEndereco);

                //}

                //    if (ItemDespacho.processopatente.inventorlista != null)
                //    {
                //        var NovaLista = ItemDespacho.processopatente.inventorlista.GroupBy(O => O.inid).ToList();
                //        string StrInventor = string.Empty; ;
                //        StrInventor = string.Empty;
                //        foreach (var item in NovaLista)
                //        {
                //            var InventorList = ItemDespacho.processopatente.inventorlista.Where(o => o.inid == item.Key).ToList();
                //            StrInventor += "(" + item.Key + ") ";
                //            foreach (var inventor in InventorList)
                //                StrInventor += inventor.nomecompleto + "; ";

                //            arquivo.WriteLine(StrInventor.Substring(0, StrInventor.Trim().Length - 1));
                //            StrInventor = string.Empty;
                //        }
                //    }
                //    if (ItemDespacho.processopatente.procuradorlista != null)
                //        foreach (var item in ItemDespacho.processopatente.procuradorlista)
                //            arquivo.WriteLine("(" + item.procurador.inid + ") " + item.procurador.nomecompleto);
                //    if (ItemDespacho.comentario != null)
                //        arquivo.WriteLine("(" + ItemDespacho.comentario.inid + ") " + ItemDespacho.comentario.Value);
            }
            arquivo.Close();
        }
    }
}
