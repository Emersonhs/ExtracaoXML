
// OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
/// <remarks/>

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class revista
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

    private decimal codigoField;

    private string tituloField;

    private processopatente processopatenteField;

    private revistaDespachoComentario comentarioField;

    /// <remarks/>
    public decimal codigo
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

    ///<remarks/>
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProcessopatenteClassificacaonacionallista
{

    private ProcessopatenteClassificacaonacionallistaClassificacaonacional[] classificacaonacionalField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("classificacao-nacional")]
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
public partial class ProcessopatenteComplementofigurarosto
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
public partial class ProcessopatenteConcessao
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
public partial class revistaDespachoProcessopatenteDatadeposito
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
public partial class ProcessopatenteDataregistroprorrogacao
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
public partial class ProcessopatentePrioridadeunionistalista
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
public partial class revistaDespachoProcessopatenteProcuradorlista
{

    private revistaDespachoProcessopatenteProcuradorlistaProcurador procuradorField;

    /// <remarks/>
    public revistaDespachoProcessopatenteProcuradorlistaProcurador procurador
    {
        get
        {
            return this.procuradorField;
        }
        set
        {
            this.procuradorField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class revistaDespachoProcessopatenteProcuradorlistaProcurador
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
public partial class ProcessopatentePublicacaonacional
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

namespace XML_v2
{
    public class DesenIndustrial
    {
        public revista revista { get; set; }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute("processo-patente", Namespace = "", IsNullable = false)]
public partial class processopatente
{

    private processopatenteNumero numeroField;
    private ProcessopatenteComplementofigurarosto ComplementofigurarostoField;
    private ProcessopatenteDivisaopedido divisaoPedidoField;
    private ProcessopatenteTitulo tituloField;

    private processopatenteDatadeposito datadepositoField;
    private ProcessopatentePublicacaonacional publicacaonacionalField;
    private ProcessopatenteDataregistroprorrogacao dataregistroprorrogacaoField;
    private ProcessopatenteConcessao concessaoField;

    private processopatenteTitularlistaTitular[] titularlistaField;
    private ProcessopatenteClassificacaonacionallista classificacaonacionallistaField;
    private ProcessopatentePrioridadeunionistalista prioridadeunionistalistaField;

    private processopatenteInventor[] inventorlistaField;

    private processopatenteProcuradorlista[] procuradorlistaField;

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
    [System.Xml.Serialization.XmlElementAttribute("complemento-figura-rosto")]
    public ProcessopatenteComplementofigurarosto complementofigurarosto
    {
        get
        {
            return this.ComplementofigurarostoField;
        }
        set
        {
            this.ComplementofigurarostoField = value;
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
    public ProcessopatenteDivisaopedido divisaopedido
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
    [System.Xml.Serialization.XmlElementAttribute("data-registro-prorrogacao")]
    public ProcessopatenteDataregistroprorrogacao dataregistroprorrogacao
    {
        get
        {
            return this.dataregistroprorrogacaoField;
        }
        set
        {
            this.dataregistroprorrogacaoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("concessao")]
    public ProcessopatenteConcessao concessao
    {
        get
        {
            return this.concessaoField;
        }
        set
        {
            this.concessaoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("publicacao-nacional")]
    public ProcessopatentePublicacaonacional publicacaonacional
    {
        get
        {
            return this.publicacaonacionalField;
        }
        set
        {
            this.publicacaonacionalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute("titular-lista")]
    [System.Xml.Serialization.XmlArrayItemAttribute("titular", IsNullable = false)]
    public processopatenteTitularlistaTitular[] titularlista
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
    [System.Xml.Serialization.XmlElementAttribute("classificacao-nacional-lista")]
    public ProcessopatenteClassificacaonacionallista classificacaonacionallista
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("prioridade-unionista-lista")]
    public ProcessopatentePrioridadeunionistalista Prioridadeunionistalista
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
    public processopatenteInventor[] inventorlista
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("procurador-lista")]
    public processopatenteProcuradorlista[] procuradorlista
    {
        get
        {
            return this.procuradorlistaField;
        }
        set
        {
            this.procuradorlistaField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class processopatenteNumero
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class processopatenteTitularlista
{

    private processopatenteTitularlistaTitular[] titularField;

    /// <remarks/>
    public processopatenteTitularlistaTitular[] titular
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class processopatenteTitularlistaTitularEndereco
{

    private string ufField;

    private processopatenteTitularlistaTitularEnderecoPais paisField;

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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class processopatenteInventor
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class processopatenteProcuradorlista
{

    private processopatenteProcuradorlistaProcurador procuradorField;

    /// <remarks/>
    public processopatenteProcuradorlistaProcurador procurador
    {
        get
        {
            return this.procuradorField;
        }
        set
        {
            this.procuradorField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class processopatenteProcuradorlistaProcurador
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

