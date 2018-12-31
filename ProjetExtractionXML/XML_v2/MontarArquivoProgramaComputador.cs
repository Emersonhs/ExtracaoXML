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
                    foreach (var itemTitulares in ItemDespacho.processoprograma.titularLista)
                    {
                        arquivo.WriteLine("(" + itemTitulares.inid + ") " + itemTitulares.nome);
                    }
                }

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

                    //lista do campo de aplicação
                    foreach (var itemCampoAplicacao in ItemDespacho.processoprograma.campoAplicacaoLista)
                    {
                        arquivo.WriteLine("(" + itemCampoAplicacao.inid + ") " + itemCampoAplicacao.inid.Value);
                    }

                    //lista do tipo de programas
                    foreach (var itemTipoPrograma in ItemDespacho.processoprograma.tipoProgramaLista)
                    {
                        arquivo.WriteLine("(" + itemTipoPrograma.inid + ") " + itemTipoPrograma.inid.Value);
                    }
                }
                //data da criação
                arquivo.WriteLine("(" + ItemDespacho.processoprograma.dataCriacao.inid + ") " + ItemDespacho.processoprograma.dataCriacao.Value);

            }
            arquivo.Close();
        }
    }
}
