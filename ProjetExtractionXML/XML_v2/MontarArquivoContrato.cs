using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.Model;

namespace XML_v2
{
    public class MontarArquivoContrato : BaseMontarArquivo
    {
        public MontarArquivoContrato() : base(Constantes.Arquivos.ContratoSaida)
        {
        }
        public void MontarArquivo(Contrato contrato)
        {
            arquivo.WriteLine("No " + contrato.numero + " de " + contrato.dataPublicacao);
            arquivo.WriteLine("|");
            arquivo.WriteLine("No " + contrato.numero + " de " + contrato.dataPublicacao);

            foreach (var ItemDespacho in contrato.despacho)
            {
                arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString().Replace('.', ','));
                if (ItemDespacho.processocontrato != null)
                {
                    if (ItemDespacho.processocontrato.numero != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.numero.inid + ") " + ItemDespacho.processocontrato.numero.Value);
                    }
                    if (ItemDespacho.processocontrato.cedentes != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.cedentes.cedente.nomeCompleto.inid + ") " + ItemDespacho.processocontrato.cedentes.cedente.nomeCompleto.Value);
                    }
                    if (ItemDespacho.processocontrato.cessionarias != null)
                    {
                        foreach (var item in ItemDespacho.processocontrato.cessionarias)
                        {
                            arquivo.WriteLine("(" + item.inid + ") " + item.nomeCompleto);
                        }
                    }
                    if (ItemDespacho.processocontrato.certificados != null)
                    {
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.numero.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.numero);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.naturezaDocumento.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.naturezaDocumento);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.textoObjeto.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.textoObjeto);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.siglaCategoria.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.siglaCategoria);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.descricaoMoeda.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.descricaoMoeda);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.valorContrato.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.valorContrato);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.formaPagamento.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.formaPagamento);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.prazoContrato.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.prazoContrato);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.prazoVigenciaPI.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.prazoVigenciaPI);
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.observacao.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.observacao);
                    }
                }
            }
            arquivo.Close();
        }
    }
}
