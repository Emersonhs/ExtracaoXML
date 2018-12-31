
// OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class ProgramaComputador
{

    private ProgramaComputadorDespacho[] despachoField;

    private ushort numeroField;

    private string dataPublicacaoField;

    private string diretoriaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("despacho")]
    public ProgramaComputadorDespacho[] despacho
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
public partial class ProgramaComputadorDespacho
{

    private ushort codigoField;

    private string tituloField;

    private revistaDespachoProcessoprograma processoprogramaField;

    private revistaDespachoComentario comentarioField;

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
    [System.Xml.Serialization.XmlElementAttribute("processo-programa")]
    public revistaDespachoProcessoprograma processoprograma
    {
        get
        {
            return this.processoprogramaField;
        }
        set
        {
            this.processoprogramaField = value;
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
public partial class revistaDespachoProcessoprograma
{

    private revistaDespachoProcessoprogramaNumero numeroField;

    private revistaDespachoProcessoprogramaTitulo tituloField;

    private revistaDespachoProcessoprogramaDataCriacao dataCriacaoField;

    private revistaDespachoProcessoprogramaCampoAplicacao[] campoAplicacaoListaField;

    private revistaDespachoProcessoprogramaLinguagem[] linguagemListaField;

    private revistaDespachoProcessoprogramaTipoPrograma[] tipoProgramaListaField;

    private revistaDespachoProcessoprogramaTitular[] titularListaField;

    private revistaDespachoProcessoprogramaCriador[] criadorListaField;

    /// <remarks/>
    public revistaDespachoProcessoprogramaNumero numero
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
    public revistaDespachoProcessoprogramaTitulo titulo
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
    public revistaDespachoProcessoprogramaDataCriacao dataCriacao
    {
        get
        {
            return this.dataCriacaoField;
        }
        set
        {
            this.dataCriacaoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("campoAplicacao", IsNullable = false)]
    public revistaDespachoProcessoprogramaCampoAplicacao[] campoAplicacaoLista
    {
        get
        {
            return this.campoAplicacaoListaField;
        }
        set
        {
            this.campoAplicacaoListaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("linguagem", IsNullable = false)]
    public revistaDespachoProcessoprogramaLinguagem[] linguagemLista
    {
        get
        {
            return this.linguagemListaField;
        }
        set
        {
            this.linguagemListaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("tipoPrograma", IsNullable = false)]
    public revistaDespachoProcessoprogramaTipoPrograma[] tipoProgramaLista
    {
        get
        {
            return this.tipoProgramaListaField;
        }
        set
        {
            this.tipoProgramaListaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("titular", IsNullable = false)]
    public revistaDespachoProcessoprogramaTitular[] titularLista
    {
        get
        {
            return this.titularListaField;
        }
        set
        {
            this.titularListaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("criador", IsNullable = false)]
    public revistaDespachoProcessoprogramaCriador[] criadorLista
    {
        get
        {
            return this.criadorListaField;
        }
        set
        {
            this.criadorListaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class revistaDespachoProcessoprogramaNumero
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
public partial class revistaDespachoProcessoprogramaTitulo
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
public partial class revistaDespachoProcessoprogramaDataCriacao
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
public partial class revistaDespachoProcessoprogramaCampoAplicacao
{

    private revistaDespachoProcessoprogramaCampoAplicacaoCodigo codigoField;

    /// <remarks/>
    public revistaDespachoProcessoprogramaCampoAplicacaoCodigo codigo
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class revistaDespachoProcessoprogramaCampoAplicacaoCodigo
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
public partial class revistaDespachoProcessoprogramaLinguagem
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
public partial class revistaDespachoProcessoprogramaTipoPrograma
{

    private revistaDespachoProcessoprogramaTipoProgramaCodigo codigoField;

    /// <remarks/>
    public revistaDespachoProcessoprogramaTipoProgramaCodigo codigo
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class revistaDespachoProcessoprogramaTipoProgramaCodigo
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
public partial class revistaDespachoProcessoprogramaTitular
{

    private string nomeField;

    private byte sequenciaField;

    private byte inidField;

    /// <remarks/>
    public string nome
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


// OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class linguagemLista
{

    private linguagemListaLinguagem[] linguagemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("linguagem")]
    public linguagemListaLinguagem[] linguagem
    {
        get
        {
            return this.linguagemField;
        }
        set
        {
            this.linguagemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class linguagemListaLinguagem
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
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class tipoProgramaLista
{

    private tipoProgramaListaTipoPrograma[] tipoProgramaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tipoPrograma")]
    public tipoProgramaListaTipoPrograma[] tipoPrograma
    {
        get
        {
            return this.tipoProgramaField;
        }
        set
        {
            this.tipoProgramaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class tipoProgramaListaTipoPrograma
{

    private tipoProgramaListaTipoProgramaCodigo codigoField;

    /// <remarks/>
    public tipoProgramaListaTipoProgramaCodigo codigo
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class tipoProgramaListaTipoProgramaCodigo
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
public partial class revistaDespachoProcessoprogramaCriador
{

    private string nomeField;

    private byte sequenciaField;

    private string inidField;

    /// <remarks/>
    public string nome
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
public partial class ProgramaComputadorDespachoComentario
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

