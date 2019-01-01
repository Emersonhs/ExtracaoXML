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
                //CÓDIGO inicial de cada despacho
                arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString());
                if (ItemDespacho.processoprograma != null)
                {
                    //"cabeçalho" de cada processo programa número + título + titular (pode ter + de 1)
                    arquivo.WriteLine("(" + ItemDespacho.processoprograma.numero.inid + ") " + ItemDespacho.processoprograma.numero.Value);
                    arquivo.WriteLine("(" + ItemDespacho.processoprograma.titulo.inid + ") " + ItemDespacho.processoprograma.titulo.Value);


                    //lista titulares
                    var NovaListaTitulares = ItemDespacho.processoprograma.titularLista.GroupBy(O => O.inid).ToList();
                    string StrTitular = string.Empty;
                    StrTitular = string.Empty;

                    foreach (var itemTitulares in NovaListaTitulares)
                    {
                        var TitularList = ItemDespacho.processoprograma.titularLista.Where(o => o.inid == itemTitulares.Key).ToList();
                        StrTitular += "(" + itemTitulares.Key + ") ";
                        foreach (var titular in TitularList)
                            StrTitular += titular.nome + "; ";

                        arquivo.WriteLine(StrTitular.Substring(0, StrTitular.Trim().Length - 1));
                        StrTitular = string.Empty;
                    }
                }

                if (ItemDespacho.processoprograma.campoAplicacaoLista != null)
                {
                    // lista dos criadores

                    var NovaListaCriadores = ItemDespacho.processoprograma.criadorLista.GroupBy(O => O.inid).ToList();
                    string StrCriadores = string.Empty;
                    StrCriadores = string.Empty;


                    foreach (var itemCriador in NovaListaCriadores)
                    {

                        var AplicacaoList = ItemDespacho.processoprograma.criadorLista.Where(o => o.inid == itemCriador.Key).ToList();
                        StrCriadores += "(" + itemCriador.Key + ") ";
                        foreach (var criador in itemCriador)
                            StrCriadores += criador.nome + "; ";

                        arquivo.WriteLine(StrCriadores.Substring(0, StrCriadores.Trim().Length - 1));
                        StrCriadores = string.Empty;

                    }


                    //lista das linguagens  

                    var NovaListaLinguagens = ItemDespacho.processoprograma.linguagemLista.GroupBy(O => O.inid).ToList();
                    string StrLinguagem = string.Empty;
                    StrLinguagem = string.Empty;


                    foreach (var itemLinguagem in NovaListaLinguagens)
                    {

                        var linguagemList = ItemDespacho.processoprograma.linguagemLista.Where(o => o.inid == itemLinguagem.Key).ToList();
                        StrLinguagem += "(" + itemLinguagem.Key + ") ";
                        foreach (var linguagem in itemLinguagem)
                            StrLinguagem += linguagem.Value + "; ";

                        arquivo.WriteLine(StrLinguagem.Substring(0, StrLinguagem.Trim().Length - 1));
                        StrLinguagem = string.Empty;
                    }


                    //lista dos campos de aplicação

                    var NovaListaAplicacao = ItemDespacho.processoprograma.campoAplicacaoLista.GroupBy(O => O.inid).ToList();
                    string StrAplicacao = string.Empty;
                    StrAplicacao = string.Empty;

                    foreach (var itemAplicacao in NovaListaAplicacao)
                    {

                        var AplicacaoList = ItemDespacho.processoprograma.campoAplicacaoLista.Where(o => o.inid == itemAplicacao.Key).ToList();
                        StrAplicacao += "(" + itemAplicacao.Key + ") ";
                        foreach (var aplicacao in itemAplicacao)
                            StrAplicacao += aplicacao.codigo.Value + "; ";

                        arquivo.WriteLine(StrAplicacao.Substring(0, StrAplicacao.Trim().Length - 1));
                        StrAplicacao = string.Empty;

                    }



                    //lista do tipo de programas


                    var NovaListaTiposProgramas = ItemDespacho.processoprograma.tipoProgramaLista.GroupBy(O => O.inid).ToList();
                    string StrTipoProgramas = string.Empty;
                    StrTipoProgramas = string.Empty;

                    foreach (var itemTipoPrograma in NovaListaTiposProgramas)
                    {

                        var TiposProgramasList = ItemDespacho.processoprograma.tipoProgramaLista.Where(o => o.inid == itemTipoPrograma.Key).ToList();
                        StrTipoProgramas += "(" + itemTipoPrograma.Key + ") ";
                        foreach (var tipoPrograma in itemTipoPrograma)
                            StrAplicacao += tipoPrograma.codigo.Value + "; ";

                        arquivo.WriteLine(StrTipoProgramas.Substring(0, StrTipoProgramas.Trim().Length - 1));
                        StrTipoProgramas = string.Empty;

                    }
                }
                //data da criação
                arquivo.WriteLine("(" + ItemDespacho.processoprograma.dataCriacao.inid + ") " + ItemDespacho.processoprograma.dataCriacao.Value);

            }
            arquivo.Close();
        }
    }
}
