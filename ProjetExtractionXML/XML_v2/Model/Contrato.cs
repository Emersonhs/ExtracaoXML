using System.Xml.Serialization;

namespace XML_v2.Model.Contrato
{

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(elementName:"revista", Namespace = "", IsNullable = false)]
   
    public partial class Contrato
    {

        private ContratoDespacho[] despachoField;

        private ushort numeroField;

        private string dataPublicacaoField;

        private string diretoriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("despacho")]
        public ContratoDespacho[] despacho
        {
            get
            {
                return this.despachoField;
            }
            set
            {
                this.despachoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dataPublicacao
        {
            get
            {
                return this.dataPublicacaoField;
            }
            set
            {
                this.dataPublicacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string diretoria
        {
            get
            {
                return this.diretoriaField;
            }
            set
            {
                this.diretoriaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespacho
    {

        private ushort codigoField;

        private string tituloField;

        private ContratoDespachoProcessocontrato processocontratoField;

        private ContratoDespachoComentario comentarioField;

        /// <remarks/>
        public ushort codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string titulo
        {
            get
            {
                return this.tituloField;
            }
            set
            {
                this.tituloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("processo-contrato")]
        public ContratoDespachoProcessocontrato processocontrato
        {
            get
            {
                return this.processocontratoField;
            }
            set
            {
                this.processocontratoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoComentario comentario
        {
            get
            {
                return this.comentarioField;
            }
            set
            {
                this.comentarioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontrato
    {

        private ContratoDespachoProcessocontratoNumero numeroField;

        private ContratoDespachoProcessocontratoCedentes cedentesField;

        private ContratoDespachoProcessocontratoCessionaria[] cessionariasField;

        private ContratoDespachoProcessocontratoDataProtocolo dataProtocoloField;

        private ContratoDespachoProcessocontratoCertificados certificadosField;

        private ContratoDespachoProcessocontratoPeticoes peticoesField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoNumero numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCedentes cedentes
        {
            get
            {
                return this.cedentesField;
            }
            set
            {
                this.cedentesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cessionaria", IsNullable = false)]
        public ContratoDespachoProcessocontratoCessionaria[] cessionarias
        {
            get
            {
                return this.cessionariasField;
            }
            set
            {
                this.cessionariasField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoDataProtocolo dataProtocolo
        {
            get
            {
                return this.dataProtocoloField;
            }
            set
            {
                this.dataProtocoloField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificados certificados
        {
            get
            {
                return this.certificadosField;
            }
            set
            {
                this.certificadosField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoPeticoes peticoes
        {
            get
            {
                return this.peticoesField;
            }
            set
            {
                this.peticoesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoNumero
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCedentes
    {

        private ContratoDespachoProcessocontratoCedentesCedente cedenteField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCedentesCedente cedente
        {
            get
            {
                return this.cedenteField;
            }
            set
            {
                this.cedenteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCedentesCedente
    {

        private ContratoDespachoProcessocontratoCedentesCedenteNomeCompleto nomeCompletoField;

        private ContratoDespachoProcessocontratoCedentesCedenteEndereco enderecoField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCedentesCedenteNomeCompleto nomeCompleto
        {
            get
            {
                return this.nomeCompletoField;
            }
            set
            {
                this.nomeCompletoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCedentesCedenteEndereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCedentesCedenteNomeCompleto
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCedentesCedenteEndereco
    {

        private ContratoDespachoProcessocontratoCedentesCedenteEnderecoPais paisField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCedentesCedenteEnderecoPais pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCedentesCedenteEnderecoPais
    {

        private ContratoDespachoProcessocontratoCedentesCedenteEnderecoPaisNome nomeField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCedentesCedenteEnderecoPaisNome nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCedentesCedenteEnderecoPaisNome
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCessionaria
    {

        private ContratoDespachoProcessocontratoCessionariaNomeCompleto nomeCompletoField;

        private ContratoDespachoProcessocontratoCessionariaEndereco enderecoField;

        private ContratoDespachoProcessocontratoCessionariaSetor setorField;
        private ContratoDespachoProcessocontratoCessionariaSetor inidField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCessionariaNomeCompleto nomeCompleto
        {
            get
            {
                return this.nomeCompletoField;
            }
            set
            {
                this.nomeCompletoField = value;
            }
        }


        /// <remarks/>
        public ContratoDespachoProcessocontratoCessionariaEndereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCessionariaSetor setor
        {
            get
            {
                return this.setorField;
            }
            set
            {
                this.setorField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCessionariaSetor inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCessionariaNomeCompleto
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCessionariaEndereco
    {

        private ContratoDespachoProcessocontratoCessionariaEnderecoPais paisField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCessionariaEnderecoPais pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCessionariaEnderecoPais
    {

        private ContratoDespachoProcessocontratoCessionariaEnderecoPaisNome nomeField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCessionariaEnderecoPaisNome nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCessionariaEnderecoPaisNome
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCessionariaSetor
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoDataProtocolo
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificados
    {

        private ContratoDespachoProcessocontratoCertificadosCertificado certificadoField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificado certificado
        {
            get
            {
                return this.certificadoField;
            }
            set
            {
                this.certificadoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificado
    {

        private ContratoDespachoProcessocontratoCertificadosCertificadoNumero numeroField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoNaturezaDocumento naturezaDocumentoField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoTextoObjeto textoObjetoField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoSiglaCategoria siglaCategoriaField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoDescricaoMoeda descricaoMoedaField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoValorContrato valorContratoField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoFormaPagamento formaPagamentoField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoPrazoContrato prazoContratoField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoPrazoVigenciaPI prazoVigenciaPIField;

        private ContratoDespachoProcessocontratoCertificadosCertificadoObservacao observacaoField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoNumero numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoNaturezaDocumento naturezaDocumento
        {
            get
            {
                return this.naturezaDocumentoField;
            }
            set
            {
                this.naturezaDocumentoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoTextoObjeto textoObjeto
        {
            get
            {
                return this.textoObjetoField;
            }
            set
            {
                this.textoObjetoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoSiglaCategoria siglaCategoria
        {
            get
            {
                return this.siglaCategoriaField;
            }
            set
            {
                this.siglaCategoriaField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoDescricaoMoeda descricaoMoeda
        {
            get
            {
                return this.descricaoMoedaField;
            }
            set
            {
                this.descricaoMoedaField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoValorContrato valorContrato
        {
            get
            {
                return this.valorContratoField;
            }
            set
            {
                this.valorContratoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoFormaPagamento formaPagamento
        {
            get
            {
                return this.formaPagamentoField;
            }
            set
            {
                this.formaPagamentoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoPrazoContrato prazoContrato
        {
            get
            {
                return this.prazoContratoField;
            }
            set
            {
                this.prazoContratoField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoPrazoVigenciaPI prazoVigenciaPI
        {
            get
            {
                return this.prazoVigenciaPIField;
            }
            set
            {
                this.prazoVigenciaPIField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoCertificadosCertificadoObservacao observacao
        {
            get
            {
                return this.observacaoField;
            }
            set
            {
                this.observacaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoNumero
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoNaturezaDocumento
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoTextoObjeto
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoSiglaCategoria
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoDescricaoMoeda
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoValorContrato
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoFormaPagamento
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoPrazoContrato
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoPrazoVigenciaPI
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoCertificadosCertificadoObservacao
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoPeticoes
    {

        private ContratoDespachoProcessocontratoPeticoesPeticao peticaoField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoPeticoesPeticao peticao
        {
            get
            {
                return this.peticaoField;
            }
            set
            {
                this.peticaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoPeticoesPeticao
    {

        private ContratoDespachoProcessocontratoPeticoesPeticaoNumero numeroField;

        private ContratoDespachoProcessocontratoPeticoesPeticaoDataProtocolo dataProtocoloField;

        private ContratoDespachoProcessocontratoPeticoesPeticaoRequerente requerenteField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoPeticoesPeticaoNumero numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoPeticoesPeticaoDataProtocolo dataProtocolo
        {
            get
            {
                return this.dataProtocoloField;
            }
            set
            {
                this.dataProtocoloField = value;
            }
        }

        /// <remarks/>
        public ContratoDespachoProcessocontratoPeticoesPeticaoRequerente requerente
        {
            get
            {
                return this.requerenteField;
            }
            set
            {
                this.requerenteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoPeticoesPeticaoNumero
    {

        private string inidField;

        private ulong valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ulong Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoPeticoesPeticaoDataProtocolo
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoPeticoesPeticaoRequerente
    {

        private ContratoDespachoProcessocontratoPeticoesPeticaoRequerenteNomeCompleto nomeCompletoField;

        /// <remarks/>
        public ContratoDespachoProcessocontratoPeticoesPeticaoRequerenteNomeCompleto nomeCompleto
        {
            get
            {
                return this.nomeCompletoField;
            }
            set
            {
                this.nomeCompletoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoProcessocontratoPeticoesPeticaoRequerenteNomeCompleto
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ContratoDespachoComentario
    {

        private string inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inid
        {
            get
            {
                return this.inidField;
            }
            set
            {
                this.inidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
