
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

    private revistaDespachoProcessopatente processopatenteField;

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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("processo-patente")]
    public revistaDespachoProcessopatente processopatente
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
public partial class revistaDespachoProcessopatente
{

    private object[] itemsField;   
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("classificacao-nacional-lista", typeof(revistaDespachoProcessopatenteClassificacaonacionallista))]
    [System.Xml.Serialization.XmlElementAttribute("complemento-figura-rosto", typeof(revistaDespachoProcessopatenteComplementofigurarosto))]
    [System.Xml.Serialization.XmlElementAttribute("concessao", typeof(revistaDespachoProcessopatenteConcessao))]
    [System.Xml.Serialization.XmlElementAttribute("data-deposito", typeof(revistaDespachoProcessopatenteDatadeposito))]
    [System.Xml.Serialization.XmlElementAttribute("data-registro-prorrogacao", typeof(revistaDespachoProcessopatenteDataregistroprorrogacao))]
    [System.Xml.Serialization.XmlElementAttribute("divisao-pedido", typeof(revistaDespachoProcessopatenteDivisaopedido))]
    [System.Xml.Serialization.XmlElementAttribute("inventor-lista", typeof(revistaDespachoProcessopatenteInventorlista))]
    [System.Xml.Serialization.XmlElementAttribute("numero", typeof(revistaDespachoProcessopatenteNumero))]
    [System.Xml.Serialization.XmlElementAttribute("prioridade-unionista-lista", typeof(revistaDespachoProcessopatentePrioridadeunionistalista))]
    [System.Xml.Serialization.XmlElementAttribute("procurador-lista", typeof(revistaDespachoProcessopatenteProcuradorlista))]
    [System.Xml.Serialization.XmlElementAttribute("publicacao-nacional", typeof(revistaDespachoProcessopatentePublicacaonacional))]
    [System.Xml.Serialization.XmlElementAttribute("titular-lista", typeof(revistaDespachoProcessopatenteTitularlista))]
    [System.Xml.Serialization.XmlElementAttribute("titulo", typeof(revistaDespachoProcessopatenteTitulo))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
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
public partial class revistaDespachoProcessopatenteDataregistroprorrogacao
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
public partial class revistaDespachoProcessopatenteDivisaopedido
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

namespace XML_v2
{
    public class DesenIndustrial
    {
        public revista revista { get; set; }
    }
}
