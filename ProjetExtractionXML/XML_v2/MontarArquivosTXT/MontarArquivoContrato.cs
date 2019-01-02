using XML_v2.ModelosXML.Contrato;

namespace XML_v2
{
    public class MontarArquivoContrato : BaseMontarArquivo
    {
        public MontarArquivoContrato() : base(Constantes.Arquivos.ContratoSaida)
        {
        }
        public void MontarArquivo(Contrato contrato)
        {
            foreach (var ItemDespacho in contrato.despacho)
            {
                arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString().Replace('.', ','));
                if (ItemDespacho.processocontrato != null)
                {

                    if (ItemDespacho.processocontrato.numero != null)
                        arquivo.WriteLine("(" + ItemDespacho.processocontrato.numero.inid + ") " + ItemDespacho.processocontrato.numero.Value);
                    if (ItemDespacho.processocontrato.certificados == null)
                    {
                        if (ItemDespacho.processocontrato.dataProtocolo != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.dataProtocolo.inid + ") " + ItemDespacho.processocontrato.dataProtocolo.Value);

                        if (ItemDespacho.processocontrato.cedentes != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.cedentes.cedente.nomeCompleto.inid + ") " + ItemDespacho.processocontrato.cedentes.cedente.nomeCompleto.Value);
                    }

                    if (ItemDespacho.processocontrato.peticoes != null)
                    {
                        if (ItemDespacho.processocontrato.peticoes.peticao.numero != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.peticoes.peticao.numero.inid + ") " +
                                ItemDespacho.processocontrato.peticoes.peticao.numero.Value);

                        if (ItemDespacho.processocontrato.peticoes.peticao.dataProtocolo != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.peticoes.peticao.dataProtocolo.inid + ") " +
                                ItemDespacho.processocontrato.peticoes.peticao.dataProtocolo.Value);


                        if (ItemDespacho.processocontrato.peticoes.peticao.requerente != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.peticoes.peticao.requerente.nomeCompleto.inid + ") " +
                                ItemDespacho.processocontrato.peticoes.peticao.requerente.nomeCompleto.Value);

                    }
                    if (ItemDespacho.processocontrato.certificados == null)
                    {
                        if (ItemDespacho.processocontrato.cessionarias != null)
                            foreach (var item in ItemDespacho.processocontrato.cessionarias)
                                arquivo.WriteLine("(" + item.nomeCompleto.inid + ") " + item.nomeCompleto.Value);
                    }
                    if (ItemDespacho.processocontrato.certificados != null)
                    {
                        if (ItemDespacho.processocontrato.certificados.certificado.numero.inid != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.numero.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.numero.Value);

                        if (ItemDespacho.processocontrato.dataProtocolo != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.dataProtocolo.inid + ") " + ItemDespacho.processocontrato.dataProtocolo.Value);

                        if (ItemDespacho.processocontrato.cedentes != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.cedentes.cedente.nomeCompleto.inid + ") "
                                + ItemDespacho.processocontrato.cedentes.cedente.nomeCompleto.Value);

                        if (ItemDespacho.processocontrato.cedentes.cedente.endereco != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.cedentes.cedente.endereco.pais.nome.inid + ") "
                                + ItemDespacho.processocontrato.cedentes.cedente.endereco.pais.nome.Value);


                        if (ItemDespacho.processocontrato.cessionarias != null)
                            foreach (var item in ItemDespacho.processocontrato.cessionarias)
                            {
                                arquivo.WriteLine("(" + item.nomeCompleto.inid + ") " + item.nomeCompleto.Value);

                                if (item.endereco != null)
                                    arquivo.WriteLine("(" + item.endereco.pais.nome.inid + ") " + item.endereco.pais.nome.Value);
                                if (item.setor != null)
                                    arquivo.WriteLine("(" + item.setor.inid + ") " + item.setor.Value);
                            }

                        if (ItemDespacho.processocontrato.certificados.certificado.naturezaDocumento != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.naturezaDocumento.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.naturezaDocumento.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.siglaCategoria != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.siglaCategoria.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.siglaCategoria.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.textoObjeto != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.textoObjeto.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.textoObjeto.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.descricaoMoeda != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.descricaoMoeda.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.descricaoMoeda.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.prazoVigenciaPI != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.prazoVigenciaPI.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.prazoVigenciaPI.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.valorContrato != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.valorContrato.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.valorContrato.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.formaPagamento != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.formaPagamento.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.formaPagamento.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.prazoContrato != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.prazoContrato.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.prazoContrato.Value);

                        if (ItemDespacho.processocontrato.certificados.certificado.observacao != null)
                            arquivo.WriteLine("(" + ItemDespacho.processocontrato.certificados.certificado.observacao.inid + ") " + ItemDespacho.processocontrato.certificados.certificado.observacao.Value);
                    }
                }
                if (ItemDespacho.comentario != null)
                    arquivo.WriteLine("(" + ItemDespacho.comentario.inid + ") " + ItemDespacho.comentario.Value);

            }
            arquivo.Close();
        }
    }
}
