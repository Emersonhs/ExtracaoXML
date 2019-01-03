using System.Xml.Serialization;

namespace XML_v2.ModelosXML.Patente
{

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "revista", Namespace = "", IsNullable = false)]
    public partial class Patente
    {


        private revistaDespacho[] despachoField;

        private ushort numeroField;

        private string dataPublicacaoField;

        private string diretoriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("despacho")]
        public revistaDespacho[] despacho
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
    public partial class revistaDespacho
    {

        private string codigoField;

        private string tituloField;

        private processopatente processopatenteField;

        private revistaDespachoComentario comentarioField;

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
        public revistaDespachoComentario comentario
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
        private ProcessopatenteDatadeposito datadepositoField;
        private ProcessopatenteDivisaopedido divisaoPedidoField;
        private processopatenteNumero numeroField;
        private ProcessopatenteTitulo tituloField;

        private processopatentePedidointernacional pedidointernacionalField;

        private processopatentePublicacaointernacional publicacaointernacionalField;

        private ProcessopatenteClassificacaonacionallista classificacaonacionallistaField;


        private processopatenteClassificacaointernacional[] classificacaointernacionallistaField;

        private processopatentePrioridadeunionista[] prioridadeunionistalistaField;
        private revistaDespachoProcessopatenteInventorlistaInventor[] InventorlistaField;
        private revistaDespachoProcessopatenteTitularlistaTitular[] titularlistaField;

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
        [System.Xml.Serialization.XmlElementAttribute("pedido-internacional")]
        public processopatentePedidointernacional pedidointernacional
        {
            get
            {
                return this.pedidointernacionalField;
            }
            set
            {
                this.pedidointernacionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-deposito")]
        public ProcessopatenteDatadeposito dataDeposito
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
        [System.Xml.Serialization.XmlElementAttribute("titulo")]
        public ProcessopatenteTitulo titulo
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
        [System.Xml.Serialization.XmlElementAttribute("divisao-pedido")]
        public ProcessopatenteDivisaopedido divisaoPedido
        {
            get
            {
                return this.divisaoPedidoField;
            }
            set
            {
                this.divisaoPedidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("publicacao-internacional")]
        public processopatentePublicacaointernacional publicacaointernacional
        {
            get
            {
                return this.publicacaointernacionalField;
            }
            set
            {
                this.publicacaointernacionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("classificacao-internacional-lista")]
        [System.Xml.Serialization.XmlArrayItemAttribute("classificacao-internacional", IsNullable = false)]
        public processopatenteClassificacaointernacional[] classificacaointernacionallista
        {
            get
            {
                return this.classificacaointernacionallistaField;
            }
            set
            {
                this.classificacaointernacionallistaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("prioridade-unionista-lista")]
        [System.Xml.Serialization.XmlArrayItemAttribute("prioridade-unionista", IsNullable = false)]
        public processopatentePrioridadeunionista[] prioridadeunionistalista
        {
            get
            {
                return this.prioridadeunionistalistaField;
            }
            set
            {
                this.prioridadeunionistalistaField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("inventor-lista")]
        [System.Xml.Serialization.XmlArrayItemAttribute("inventor", IsNullable = false)]
        public revistaDespachoProcessopatenteInventorlistaInventor[] Inventorlista
        {
            get
            {
                return this.InventorlistaField;
            }
            set
            {
                this.InventorlistaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("titular-lista")]
        [System.Xml.Serialization.XmlArrayItemAttribute("titular", IsNullable = false)]
        public revistaDespachoProcessopatenteTitularlistaTitular[] titularlista
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
        [System.Xml.Serialization.XmlAttribute("classificacao-nacional-lista")]
        public ProcessopatenteClassificacaonacionallista clasificacaoNacionalLista
        {
            get
            {
                return this.classificacaonacionallistaField;
            }
            set
            {
                this.classificacaonacionallistaField = value;
            }
        }

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProcessopatenteClassificacaonacionallista
    {

        private ProcessopatenteClassificacaonacionallistaClassificacaonacional[] classificacaonacionalField;

        /// <remarks/>
        [XmlElementAttribute("classificacao-nacional")]
        public ProcessopatenteClassificacaonacionallistaClassificacaonacional[] classificacaonacional
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
    public partial class ProcessopatenteClassificacaonacionallistaClassificacaonacional
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
    public partial class ProcessopatenteTitulo
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


    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("inventor-lista", Namespace = "", IsNullable = false)]
    public partial class inventorlista
    {

        private inventorlistaInventor[] inventorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inventor")]
        public inventorlistaInventor[] inventor
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class processopatentePedidointernacional
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
    public partial class processopatentePublicacaointernacional
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
    public partial class processopatenteClassificacaointernacional
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
    public partial class processopatentePrioridadeunionista
    {

        private processopatentePrioridadeunionistaSiglapais siglapaisField;

        private processopatentePrioridadeunionistaNumeroprioridade numeroprioridadeField;

        private processopatentePrioridadeunionistaDataprioridade dataprioridadeField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sigla-pais")]
        public processopatentePrioridadeunionistaSiglapais siglapais
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
        public processopatentePrioridadeunionistaNumeroprioridade numeroprioridade
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
        public processopatentePrioridadeunionistaDataprioridade dataprioridade
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
    public partial class processopatentePrioridadeunionistaSiglapais
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
    public partial class processopatentePrioridadeunionistaNumeroprioridade
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
    public partial class processopatentePrioridadeunionistaDataprioridade
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


    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class revistaDespachoProcessopatente
    //{

    //    private object[] itemsField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("classificacao-internacional-lista", typeof(revistaDespachoProcessopatenteClassificacaointernacionallista))]
    //    [System.Xml.Serialization.XmlElementAttribute("classificacao-nacional-lista", typeof(revistaDespachoProcessopatenteClassificacaonacionallista))]
    //    [System.Xml.Serialization.XmlElementAttribute("complemento-figura-rosto", typeof(revistaDespachoProcessopatenteComplementofigurarosto))]
    //    [System.Xml.Serialization.XmlElementAttribute("concessao", typeof(revistaDespachoProcessopatenteConcessao))]
    //    [System.Xml.Serialization.XmlElementAttribute("data-deposito", typeof(revistaDespachoProcessopatenteDatadeposito))]
    //    [System.Xml.Serialization.XmlElementAttribute("data-fase-nacional", typeof(revistaDespachoProcessopatenteDatafasenacional))]
    //    [System.Xml.Serialization.XmlElementAttribute("divisao-pedido", typeof(revistaDespachoProcessopatenteDivisaopedido))]
    //    [System.Xml.Serialization.XmlElementAttribute("inventor-lista", typeof(revistaDespachoProcessopatenteInventorlista))]
    //    [System.Xml.Serialization.XmlElementAttribute("numero", typeof(revistaDespachoProcessopatenteNumero))]
    //    [System.Xml.Serialization.XmlElementAttribute("pedido-internacional", typeof(revistaDespachoProcessopatentePedidointernacional))]
    //    [System.Xml.Serialization.XmlElementAttribute("pedido-principal", typeof(revistaDespachoProcessopatentePedidoprincipal))]
    //    [System.Xml.Serialization.XmlElementAttribute("prioridade-interna-lista", typeof(revistaDespachoProcessopatentePrioridadeinternalista))]
    //    [System.Xml.Serialization.XmlElementAttribute("prioridade-unionista-lista", typeof(revistaDespachoProcessopatentePrioridadeunionistalista))]
    //    [System.Xml.Serialization.XmlElementAttribute("publicacao-internacional", typeof(revistaDespachoProcessopatentePublicacaointernacional))]
    //    [System.Xml.Serialization.XmlElementAttribute("publicacao-nacional", typeof(revistaDespachoProcessopatentePublicacaonacional))]
    //    [System.Xml.Serialization.XmlElementAttribute("titular-lista", typeof(revistaDespachoProcessopatenteTitularlista))]
    //    [System.Xml.Serialization.XmlElementAttribute("titulo", typeof(revistaDespachoProcessopatenteTitulo))]
    //    public object[] Items
    //    {
    //        get
    //        {
    //            return this.itemsField;
    //        }
    //        set
    //        {
    //            this.itemsField = value;
    //        }
    //    }
    //}

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class revistaDespachoProcessopatenteClassificacaointernacionallista
    {

        private revistaDespachoProcessopatenteClassificacaointernacionallistaClassificacaointernacional[] classificacaointernacionalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classificacao-internacional")]
        public revistaDespachoProcessopatenteClassificacaointernacionallistaClassificacaointernacional[] classificacaointernacional
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
    public partial class revistaDespachoProcessopatenteClassificacaointernacionallistaClassificacaointernacional
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
    public partial class revistaDespachoProcessopatenteClassificacaonacionallista
    {

        private revistaDespachoProcessopatenteClassificacaonacionallistaClassificacaonacional[] classificacaonacionalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classificacao-nacional")]
        public revistaDespachoProcessopatenteClassificacaonacionallistaClassificacaonacional[] classificacaonacional
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
    public partial class revistaDespachoProcessopatenteClassificacaonacionallistaClassificacaonacional
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
    public partial class revistaDespachoProcessopatenteComplementofigurarosto
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
    public partial class revistaDespachoProcessopatenteConcessao
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
    public partial class ProcessopatenteDatadeposito
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
    public partial class revistaDespachoProcessopatenteDatafasenacional
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
    public partial class ProcessopatenteDivisaopedido
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
    public partial class revistaDespachoProcessopatenteInventorlista
    {

        private revistaDespachoProcessopatenteInventorlistaInventor[] inventorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inventor")]
        public revistaDespachoProcessopatenteInventorlistaInventor[] inventor
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
    public partial class revistaDespachoProcessopatenteInventorlistaInventor
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
    public partial class revistaDespachoProcessopatenteNumero
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
    public partial class revistaDespachoProcessopatentePedidointernacional
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
    public partial class revistaDespachoProcessopatentePedidoprincipal
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
    public partial class revistaDespachoProcessopatentePrioridadeinternalista
    {

        private revistaDespachoProcessopatentePrioridadeinternalistaPrioridadeinterna prioridadeinternaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prioridade-interna")]
        public revistaDespachoProcessopatentePrioridadeinternalistaPrioridadeinterna prioridadeinterna
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
    public partial class revistaDespachoProcessopatentePrioridadeinternalistaPrioridadeinterna
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
    public partial class revistaDespachoProcessopatentePrioridadeunionistalista
    {

        private revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionista[] prioridadeunionistaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prioridade-unionista")]
        public revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionista[] prioridadeunionista
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
    public partial class revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionista
    {

        private revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaSiglapais siglapaisField;

        private revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaNumeroprioridade numeroprioridadeField;

        private revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaDataprioridade dataprioridadeField;

        private byte inidField;

        private byte sequenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sigla-pais")]
        public revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaSiglapais siglapais
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
        public revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaNumeroprioridade numeroprioridade
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
        public revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaDataprioridade dataprioridade
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
    public partial class revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaSiglapais
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
    public partial class revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaNumeroprioridade
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
    public partial class revistaDespachoProcessopatentePrioridadeunionistalistaPrioridadeunionistaDataprioridade
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
    public partial class revistaDespachoProcessopatentePublicacaointernacional
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
    public partial class revistaDespachoProcessopatentePublicacaonacional
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
    public partial class revistaDespachoProcessopatenteTitularlista
    {

        private revistaDespachoProcessopatenteTitularlistaTitular[] titularField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("titular")]
        public revistaDespachoProcessopatenteTitularlistaTitular[] titular
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
    public partial class revistaDespachoProcessopatenteTitularlistaTitular
    {

        private string nomecompletoField;

        private revistaDespachoProcessopatenteTitularlistaTitularEndereco enderecoField;

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
        public revistaDespachoProcessopatenteTitularlistaTitularEndereco endereco
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
    public partial class revistaDespachoProcessopatenteTitularlistaTitularEndereco
    {

        private string ufField;

        private revistaDespachoProcessopatenteTitularlistaTitularEnderecoPais paisField;

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
        public revistaDespachoProcessopatenteTitularlistaTitularEnderecoPais pais
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
    public partial class revistaDespachoProcessopatenteTitularlistaTitularEnderecoPais
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
    public partial class revistaDespachoProcessopatenteTitulo
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
    public partial class revistaDespachoComentario
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
