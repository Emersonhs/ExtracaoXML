using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XML_v2
{
    class DesenhosIndustriais
    {
        // variáveis para as linhas onde a pessoa possua um end com país e estado
        private string pais = "", estado = "", atributoAtual = "";

        /////////               DESENHOS INDUSTRIAIS               /////////

        //caminho lendo arquivo diretamente da pasta BIN

        private string sCaminhoDoArquivo = ("Arquivos/DesenhoIndustrial_2502.xml");

        //Criação do arquivo
        StreamWriter arquivo = new StreamWriter("Desenho_Industrial.txt");

        List<XmlAttribute> elementos = new List<XmlAttribute>();


        public DesenhosIndustriais()
        {
        }


        public void LerArquivo()
        {

            ////Lendo XML
            XmlTextReader xml = new XmlTextReader(sCaminhoDoArquivo);
            {

                xml.Read();

                //No 2502 de 18/12/2018
                arquivo.WriteLine("No " + xml.GetAttribute(0) + " de " + xml.GetAttribute(1));
                arquivo.WriteLine("|");
                
                    arquivo.Write("No " + xml.GetAttribute(0) + " de " + xml.GetAttribute(1));

                while (xml.Read())
                {

                    //a leitura do arquivo .xml será feita em "blocos de despachos"
                    if (xml.NodeType == XmlNodeType.Element && xml.Name == "despacho")
                    {
                        //lê o próximo nó até que encontre o código inicial
                        while (xml.Name != "codigo")
                        {
                            xml.Read();
                        }
                        xml.Read();

                        //linha para escrita do codigo inicial de cada "despacho"
                        arquivo.Write("\n" + "(Cd) " + xml.Value.ToString());

                        //linha abaixo determina a saída do bloco de despacho
                        while (xml.Name != "despacho")
                        {
                            xml.Read();
                            //se o elemento tiver um atributo, escreve o atributo na tela & escreve o valor do elemento
                            //ex: 
                            //<numero inid="Np">BR 70 2018 000335-9</numero>
                            // imprime na tela: (Np) BR 70 2018 000335-9


                            if (xml.AttributeCount != 0 && xml.GetAttribute(0) != atributoAtual && xml.NodeType != XmlNodeType.EndElement)
                            {
                                if (xml.AttributeCount != 0)
                                {
                                    atributoAtual = xml.GetAttribute(0); //variável atributo atual recebe o novo atributo
                                }
                                // if para verificação se há mais de 01 atributo
                                if (xml.HasAttributes == true && xml.AttributeCount == 1)
                                {
                                    arquivo.Write("\n" + "(" + xml.GetAttribute(0) + ") ");

                                    xml.Read();
                                    while (xml.NodeType == XmlNodeType.Whitespace)
                                    {
                                        xml.Read();
                                    }
                                    //  xml.Read();
                                    arquivo.Write(xml.Value.ToString());
                                }

                                //se tiver dois atributos, significa que terá as siglas do estado e país
                                else if (xml.HasAttributes == true && xml.AttributeCount == 2 && xml.GetAttribute(0) != "/n")
                                {
                                    arquivo.Write("\n" + "(" + xml.GetAttribute(0) + ") ");

                                    xml.Read();

                                    while (xml.NodeType == XmlNodeType.Whitespace)
                                    {
                                        xml.Read();
                                    }
                                    xml.Read();
                                    arquivo.Write(xml.Value.ToString());
                                }

                            }

                            //se já existir o atributo nesta tupla, vai escrever na mesma linha, separado do "; "
                            else if (xml.AttributeCount != 0 && xml.GetAttribute(0) == atributoAtual)
                            {
                                xml.Read();
                                while (xml.NodeType == XmlNodeType.Whitespace)
                                {
                                    xml.Read();
                                }
                                xml.Read();
                                arquivo.Write("; " + xml.Value.ToString());
                            }


                            //inclusão do uf e sigla do estado
                            if (xml.Name == "uf" && xml.IsStartElement() == true)
                            {
                                xml.Read();
                                estado = xml.Value;
                            }
                            else if (xml.Name == "sigla" && xml.IsStartElement() == true)
                            {
                                xml.Read();
                                pais = xml.Value;
                                EscritaUFPais(pais, estado);
                                //reinicializaão das varáveis
                                pais = "";
                                estado = "";
                            }


                        }
                    }
                }
            }
            arquivo.Close();
        }

        internal void EscritaUFPais(string pais, string estado)
        {
            if (estado == "")
            {
                arquivo.Write(" ({0})", pais.ToString());
            }
            else if (estado != "")
            {
                arquivo.Write(" ({0}/{1})", pais.ToString(), estado.ToString());
            }
        }
    }
}