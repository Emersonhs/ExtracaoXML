namespace XML_v2.ModelosXML.Patente
{

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(elementName:"revista", Namespace = "", IsNullable = false)]
    public partial class Patente
    {

        private PatentesDespacho[] despachoField;

        private ushort numeroField;

        private string dataPublicacaoField;

        private string diretoriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("despacho")]
        public PatentesDespacho[] despacho
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
    public partial class PatentesDespacho
    {

        private string codigoField;

        private string tituloField;

        private processopatente processopatenteField;

        private PatentesDespachoComentario comentarioField;

        /// <remarks/>
        public string codigo
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
        [System.Xml.Serialization.XmlElementAttribute("processo-patente")]
        public processopatente processopatente
        {
            get
            {
                return this.processopatenteField;
            }
            set
            {
                this.processopatenteField = value;
            }
        }

        /// <remarks/>
        public PatentesDespachoComentario comentario
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

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("processo-patente", Namespace = "", IsNullable = false)]
    public partial class processopatente
    {

        private processopatenteNumero numeroField;

        private processopatenteDatadeposito datadepositoField;

        private processopatenteDivisaopedido divisaopedidoField;

        private ProcessopatentePedidointernacional PedidointernacionalField;

        private processopatenteTitularlista[] titularlistaField;

        private PatentesDespachoProcessopatenteInventorlistaInventor[] inventorlistaField;

        /// <remarks/>
        public processopatenteNumero numero
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
        [System.Xml.Serialization.XmlElementAttribute("data-deposito")]
        public processopatenteDatadeposito datadeposito
        {
            get
            {
                return this.datadepositoField;
            }
            set
            {
                this.datadepositoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pedido-internacional")]
        public ProcessopatentePedidointernacional pedidointernacional
        {
            get
            {
                return this.PedidointernacionalField;
            }
            set
            {
                this.PedidointernacionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("divisao-pedido")]
        public processopatenteDivisaopedido divisaopedido
        {
            get
            {
                return this.divisaopedidoField;
            }
            set
            {
                this.divisaopedidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("titular-lista")]
        public processopatenteTitularlista[] titularlista
        {
            get
            {
                return this.titularlistaField;
            }
            set
            {
                this.titularlistaField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("inventor-lista")]
        [System.Xml.Serialization.XmlArrayItemAttribute("inventor", IsNullable = false)]
        public PatentesDespachoProcessopatenteInventorlistaInventor[] Inventorlista
        {
            get
            {
                return this.inventorlistaField;
            }
            set
            {
                this.inventorlistaField = value;
            }
        }
    }

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("inventor-lista", Namespace = "", IsNullable = false)]
    public partial class inventorlista
    {

        private inventorlistaInventor inventorField;

        /// <remarks/>
        public inventorlistaInventor inventor
        {
            get
            {
                return this.inventorField;
            }
            set
            {
                this.inventorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class inventorlistaInventor
    {

        private string nomecompletoField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nome-completo")]
        public string nomecompleto
        {
            get
            {
                return this.nomecompletoField;
            }
            set
            {
                this.nomecompletoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
            }
        }
    }



    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class processopatenteNumero
    {

        private byte inidField;

        private string kindcodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kindcode
        {
            get
            {
                return this.kindcodeField;
            }
            set
            {
                this.kindcodeField = value;
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
    public partial class processopatenteDatadeposito
    {

        private byte inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class processopatenteDivisaopedido
    {

        private string datadepositoField;

        private string numeroField;

        private byte inidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-deposito")]
        public string datadeposito
        {
            get
            {
                return this.datadepositoField;
            }
            set
            {
                this.datadepositoField = value;
            }
        }

        /// <remarks/>
        public string numero
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
        public byte inid
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
    public partial class processopatenteTitularlista
    {

        private processopatenteTitularlistaTitular titularField;

        /// <remarks/>
        public processopatenteTitularlistaTitular titular
        {
            get
            {
                return this.titularField;
            }
            set
            {
                this.titularField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class processopatenteTitularlistaTitular
    {

        private string nomecompletoField;

        private processopatenteTitularlistaTitularEndereco enderecoField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nome-completo")]
        public string nomecompleto
        {
            get
            {
                return this.nomecompletoField;
            }
            set
            {
                this.nomecompletoField = value;
            }
        }

        /// <remarks/>
        public processopatenteTitularlistaTitularEndereco endereco
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class processopatenteTitularlistaTitularEndereco
    {
        private string ufField{get;set;}
        private processopatenteTitularlistaTitularEnderecoPais paisField;
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public processopatenteTitularlistaTitularEnderecoPais pais
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
    public partial class processopatenteTitularlistaTitularEnderecoPais
    {

        private string siglaField;

        /// <remarks/>
        public string sigla
        {
            get
            {
                return this.siglaField;
            }
            set
            {
                this.siglaField = value;
            }
        }
    }


   

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteClassificacaointernacionallista
    {

        private PatentesDespachoProcessopatenteClassificacaointernacionallistaClassificacaointernacional[] classificacaointernacionalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classificacao-internacional")]
        public PatentesDespachoProcessopatenteClassificacaointernacionallistaClassificacaointernacional[] classificacaointernacional
        {
            get
            {
                return this.classificacaointernacionalField;
            }
            set
            {
                this.classificacaointernacionalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteClassificacaointernacionallistaClassificacaointernacional
    {

        private byte inidField;

        private byte sequenciaField;

        private decimal anoField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ano
        {
            get
            {
                return this.anoField;
            }
            set
            {
                this.anoField = value;
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
    public partial class PatentesDespachoProcessopatenteClassificacaonacionallista
    {

        private PatentesDespachoProcessopatenteClassificacaonacionallistaClassificacaonacional[] classificacaonacionalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classificacao-nacional")]
        public PatentesDespachoProcessopatenteClassificacaonacionallistaClassificacaonacional[] classificacaonacional
        {
            get
            {
                return this.classificacaonacionalField;
            }
            set
            {
                this.classificacaonacionalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteClassificacaonacionallistaClassificacaonacional
    {

        private byte inidField;

        private byte sequenciaField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
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
    public partial class PatentesDespachoProcessopatenteComplementofigurarosto
    {

        private string inidField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteConcessao
    {

        private string dataField;

        private byte inidField;

        /// <remarks/>
        public string data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatenteDatadeposito
    {

        private byte inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatenteDatafasenacional
    {

        private byte inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatenteDivisaopedido
    {

        private string datadepositoField;

        private string numeroField;

        private byte inidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-deposito")]
        public string datadeposito
        {
            get
            {
                return this.datadepositoField;
            }
            set
            {
                this.datadepositoField = value;
            }
        }

        /// <remarks/>
        public string numero
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
        public byte inid
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
    public partial class PatentesDespachoProcessopatenteInventorlista
    {

        private PatentesDespachoProcessopatenteInventorlistaInventor inventorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inventor")]
        public PatentesDespachoProcessopatenteInventorlistaInventor inventor
        {
            get
            {
                return this.inventorField;
            }
            set
            {
                this.inventorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteInventorlistaInventor
    {

        private string nomecompletoField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nome-completo")]
        public string nomecompleto
        {
            get
            {
                return this.nomecompletoField;
            }
            set
            {
                this.nomecompletoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteNumero
    {

        private byte inidField;

        private string kindcodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kindcode
        {
            get
            {
                return this.kindcodeField;
            }
            set
            {
                this.kindcodeField = value;
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
    public partial class ProcessopatentePedidointernacional
    {

        private string numeropctField;

        private string datapctField;

        private byte inidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-pct")]
        public string numeropct
        {
            get
            {
                return this.numeropctField;
            }
            set
            {
                this.numeropctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-pct")]
        public string datapct
        {
            get
            {
                return this.datapctField;
            }
            set
            {
                this.datapctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatentePedidoprincipal
    {

        private string datadepositoField;

        private string numeroField;

        private byte inidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-deposito")]
        public string datadeposito
        {
            get
            {
                return this.datadepositoField;
            }
            set
            {
                this.datadepositoField = value;
            }
        }

        /// <remarks/>
        public string numero
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
        public byte inid
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
    public partial class PatentesDespachoProcessopatentePrioridadeinternalista
    {

        private PatentesDespachoProcessopatentePrioridadeinternalistaPrioridadeinterna prioridadeinternaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prioridade-interna")]
        public PatentesDespachoProcessopatentePrioridadeinternalistaPrioridadeinterna prioridadeinterna
        {
            get
            {
                return this.prioridadeinternaField;
            }
            set
            {
                this.prioridadeinternaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatentePrioridadeinternalistaPrioridadeinterna
    {

        private string dataprioridadeField;

        private string numeroprioridadeField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-prioridade")]
        public string dataprioridade
        {
            get
            {
                return this.dataprioridadeField;
            }
            set
            {
                this.dataprioridadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-prioridade")]
        public string numeroprioridade
        {
            get
            {
                return this.numeroprioridadeField;
            }
            set
            {
                this.numeroprioridadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatentePrioridadeunionistalista
    {

        private PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionista[] prioridadeunionistaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prioridade-unionista")]
        public PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionista[] prioridadeunionista
        {
            get
            {
                return this.prioridadeunionistaField;
            }
            set
            {
                this.prioridadeunionistaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionista
    {

        private PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaSiglapais siglapaisField;

        private PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaNumeroprioridade numeroprioridadeField;

        private PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaDataprioridade dataprioridadeField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sigla-pais")]
        public PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaSiglapais siglapais
        {
            get
            {
                return this.siglapaisField;
            }
            set
            {
                this.siglapaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-prioridade")]
        public PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaNumeroprioridade numeroprioridade
        {
            get
            {
                return this.numeroprioridadeField;
            }
            set
            {
                this.numeroprioridadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-prioridade")]
        public PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaDataprioridade dataprioridade
        {
            get
            {
                return this.dataprioridadeField;
            }
            set
            {
                this.dataprioridadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaSiglapais
    {

        private byte inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaNumeroprioridade
    {

        private byte inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaDataprioridade
    {

        private byte inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatentePublicacaointernacional
    {

        private string numeroompiField;

        private string dataompiField;

        private byte inidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numero-ompi")]
        public string numeroompi
        {
            get
            {
                return this.numeroompiField;
            }
            set
            {
                this.numeroompiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-ompi")]
        public string dataompi
        {
            get
            {
                return this.dataompiField;
            }
            set
            {
                this.dataompiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatentePublicacaonacional
    {

        private string datarpiField;

        private byte inidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-rpi")]
        public string datarpi
        {
            get
            {
                return this.datarpiField;
            }
            set
            {
                this.datarpiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoProcessopatenteTitularlista
    {

        private PatentesDespachoProcessopatenteTitularlistaTitular[] titularField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("titular")]
        public PatentesDespachoProcessopatenteTitularlistaTitular[] titular
        {
            get
            {
                return this.titularField;
            }
            set
            {
                this.titularField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteTitularlistaTitular
    {

        private string nomecompletoField;

        private PatentesDespachoProcessopatenteTitularlistaTitularEndereco enderecoField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nome-completo")]
        public string nomecompleto
        {
            get
            {
                return this.nomecompletoField;
            }
            set
            {
                this.nomecompletoField = value;
            }
        }

        /// <remarks/>
        public PatentesDespachoProcessopatenteTitularlistaTitularEndereco endereco
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequencia
        {
            get
            {
                return this.sequenciaField;
            }
            set
            {
                this.sequenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteTitularlistaTitularEndereco
    {

        private string ufField;

        private PatentesDespachoProcessopatenteTitularlistaTitularEnderecoPais paisField;

        /// <remarks/>
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public PatentesDespachoProcessopatenteTitularlistaTitularEnderecoPais pais
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
    public partial class PatentesDespachoProcessopatenteTitularlistaTitularEnderecoPais
    {

        private string siglaField;

        /// <remarks/>
        public string sigla
        {
            get
            {
                return this.siglaField;
            }
            set
            {
                this.siglaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatentesDespachoProcessopatenteTitulo
    {

        private byte inidField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inid
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
    public partial class PatentesDespachoComentario
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
