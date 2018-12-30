using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2.Model
{
    public class Contrato
    {


        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
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

            private ushort codigoField;

            private string tituloField;

            private revistaDespachoProcessocontrato processocontratoField;

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
            [System.Xml.Serialization.XmlElementAttribute("processo-contrato")]
            public revistaDespachoProcessocontrato processocontrato
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
        public partial class revistaDespachoProcessocontrato
        {

            private revistaDespachoProcessocontratoNumero numeroField;

            private revistaDespachoProcessocontratoCedentes cedentesField;

            private revistaDespachoProcessocontratoCessionaria[] cessionariasField;

            private revistaDespachoProcessocontratoDataProtocolo dataProtocoloField;

            private revistaDespachoProcessocontratoCertificados certificadosField;

            private revistaDespachoProcessocontratoPeticoes peticoesField;

            /// <remarks/>
            public revistaDespachoProcessocontratoNumero numero
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
            public revistaDespachoProcessocontratoCedentes cedentes
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
            public revistaDespachoProcessocontratoCessionaria[] cessionarias
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
            public revistaDespachoProcessocontratoDataProtocolo dataProtocolo
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
            public revistaDespachoProcessocontratoCertificados certificados
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
            public revistaDespachoProcessocontratoPeticoes peticoes
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
        public partial class revistaDespachoProcessocontratoNumero
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
        public partial class revistaDespachoProcessocontratoCedentes
        {

            private revistaDespachoProcessocontratoCedentesCedente cedenteField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCedentesCedente cedente
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
        public partial class revistaDespachoProcessocontratoCedentesCedente
        {

            private revistaDespachoProcessocontratoCedentesCedenteNomeCompleto nomeCompletoField;

            private revistaDespachoProcessocontratoCedentesCedenteEndereco enderecoField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCedentesCedenteNomeCompleto nomeCompleto
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
            public revistaDespachoProcessocontratoCedentesCedenteEndereco endereco
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
        public partial class revistaDespachoProcessocontratoCedentesCedenteNomeCompleto
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
        public partial class revistaDespachoProcessocontratoCedentesCedenteEndereco
        {

            private revistaDespachoProcessocontratoCedentesCedenteEnderecoPais paisField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCedentesCedenteEnderecoPais pais
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
        public partial class revistaDespachoProcessocontratoCedentesCedenteEnderecoPais
        {

            private revistaDespachoProcessocontratoCedentesCedenteEnderecoPaisNome nomeField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCedentesCedenteEnderecoPaisNome nome
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
        public partial class revistaDespachoProcessocontratoCedentesCedenteEnderecoPaisNome
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
        public partial class revistaDespachoProcessocontratoCessionaria
        {

            private revistaDespachoProcessocontratoCessionariaNomeCompleto nomeCompletoField;

            private revistaDespachoProcessocontratoCessionariaEndereco enderecoField;

            private revistaDespachoProcessocontratoCessionariaSetor setorField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCessionariaNomeCompleto nomeCompleto
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
            public revistaDespachoProcessocontratoCessionariaEndereco endereco
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
            public revistaDespachoProcessocontratoCessionariaSetor setor
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class revistaDespachoProcessocontratoCessionariaNomeCompleto
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
        public partial class revistaDespachoProcessocontratoCessionariaEndereco
        {

            private revistaDespachoProcessocontratoCessionariaEnderecoPais paisField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCessionariaEnderecoPais pais
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
        public partial class revistaDespachoProcessocontratoCessionariaEnderecoPais
        {

            private revistaDespachoProcessocontratoCessionariaEnderecoPaisNome nomeField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCessionariaEnderecoPaisNome nome
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
        public partial class revistaDespachoProcessocontratoCessionariaEnderecoPaisNome
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
        public partial class revistaDespachoProcessocontratoCessionariaSetor
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
        public partial class revistaDespachoProcessocontratoDataProtocolo
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
        public partial class revistaDespachoProcessocontratoCertificados
        {

            private revistaDespachoProcessocontratoCertificadosCertificado certificadoField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCertificadosCertificado certificado
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificado
        {

            private revistaDespachoProcessocontratoCertificadosCertificadoNumero numeroField;

            private revistaDespachoProcessocontratoCertificadosCertificadoNaturezaDocumento naturezaDocumentoField;

            private revistaDespachoProcessocontratoCertificadosCertificadoTextoObjeto textoObjetoField;

            private revistaDespachoProcessocontratoCertificadosCertificadoSiglaCategoria siglaCategoriaField;

            private revistaDespachoProcessocontratoCertificadosCertificadoDescricaoMoeda descricaoMoedaField;

            private revistaDespachoProcessocontratoCertificadosCertificadoValorContrato valorContratoField;

            private revistaDespachoProcessocontratoCertificadosCertificadoFormaPagamento formaPagamentoField;

            private revistaDespachoProcessocontratoCertificadosCertificadoPrazoContrato prazoContratoField;

            private revistaDespachoProcessocontratoCertificadosCertificadoPrazoVigenciaPI prazoVigenciaPIField;

            private revistaDespachoProcessocontratoCertificadosCertificadoObservacao observacaoField;

            /// <remarks/>
            public revistaDespachoProcessocontratoCertificadosCertificadoNumero numero
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
            public revistaDespachoProcessocontratoCertificadosCertificadoNaturezaDocumento naturezaDocumento
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
            public revistaDespachoProcessocontratoCertificadosCertificadoTextoObjeto textoObjeto
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
            public revistaDespachoProcessocontratoCertificadosCertificadoSiglaCategoria siglaCategoria
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
            public revistaDespachoProcessocontratoCertificadosCertificadoDescricaoMoeda descricaoMoeda
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
            public revistaDespachoProcessocontratoCertificadosCertificadoValorContrato valorContrato
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
            public revistaDespachoProcessocontratoCertificadosCertificadoFormaPagamento formaPagamento
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
            public revistaDespachoProcessocontratoCertificadosCertificadoPrazoContrato prazoContrato
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
            public revistaDespachoProcessocontratoCertificadosCertificadoPrazoVigenciaPI prazoVigenciaPI
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
            public revistaDespachoProcessocontratoCertificadosCertificadoObservacao observacao
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoNumero
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoNaturezaDocumento
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoTextoObjeto
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoSiglaCategoria
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoDescricaoMoeda
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoValorContrato
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoFormaPagamento
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoPrazoContrato
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoPrazoVigenciaPI
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
        public partial class revistaDespachoProcessocontratoCertificadosCertificadoObservacao
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
        public partial class revistaDespachoProcessocontratoPeticoes
        {

            private revistaDespachoProcessocontratoPeticoesPeticao peticaoField;

            /// <remarks/>
            public revistaDespachoProcessocontratoPeticoesPeticao peticao
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
        public partial class revistaDespachoProcessocontratoPeticoesPeticao
        {

            private revistaDespachoProcessocontratoPeticoesPeticaoNumero numeroField;

            private revistaDespachoProcessocontratoPeticoesPeticaoDataProtocolo dataProtocoloField;

            private revistaDespachoProcessocontratoPeticoesPeticaoRequerente requerenteField;

            /// <remarks/>
            public revistaDespachoProcessocontratoPeticoesPeticaoNumero numero
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
            public revistaDespachoProcessocontratoPeticoesPeticaoDataProtocolo dataProtocolo
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
            public revistaDespachoProcessocontratoPeticoesPeticaoRequerente requerente
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
        public partial class revistaDespachoProcessocontratoPeticoesPeticaoNumero
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
        public partial class revistaDespachoProcessocontratoPeticoesPeticaoDataProtocolo
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
        public partial class revistaDespachoProcessocontratoPeticoesPeticaoRequerente
        {

            private revistaDespachoProcessocontratoPeticoesPeticaoRequerenteNomeCompleto nomeCompletoField;

            /// <remarks/>
            public revistaDespachoProcessocontratoPeticoesPeticaoRequerenteNomeCompleto nomeCompleto
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
        public partial class revistaDespachoProcessocontratoPeticoesPeticaoRequerenteNomeCompleto
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
}
