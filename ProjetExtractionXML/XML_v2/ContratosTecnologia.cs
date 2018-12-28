using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XML_v2
{
    class ContratosTecnologia
    {

        /////////               CONTRATOS DE TECNOLOGIA               /////////

        //caminho lendo arquivo diretamente da pasta BIN

        private string sCaminhoDoArquivo = ("Arquivos/Contratos_2495.xml");
        private string codINID = "", valorINID = "", no = "";


        //Criação do arquivo
        StreamWriter arquivo = new StreamWriter("arquivo.txt");

        List<XmlAttribute> elementos = new List<XmlAttribute>();

        public ContratosTecnologia(string cINID, string vINID)
        {
            this.codINID = cINID;
            this.valorINID = vINID;
        }

        public ContratosTecnologia()
        {

        }

        public void LerArquivo()
        {

            ////Lendo XML
            XmlTextReader xml = new XmlTextReader(sCaminhoDoArquivo);
            {
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
                        arquivo.WriteLine("(CD) " + xml.Value);

                        //linha abaixo determina a saída do bloco de despacho
                        while (xml.Name != "despacho")
                        {
                            xml.Read();
                            {
                                //se o elemento tiver um atributo, escreve o atributo na tela & escreve o valor do elemento
                                //ex: 
                                //<numero inid="Np">BR 70 2018 000335-9</numero>
                                // imprime na tela: (Np) BR 70 2018 000335-9
                                if (xml.HasAttributes == true)
                                {
                                    //ContratosTecnologia CT = new ContratosTecnologia(xml.GetAttribute(0), xml.Value);
                                    //elementos.Add(CT);
                                    ////escrita no arquivo
                                    arquivo.Write("(" + xml.GetAttribute(0) + ") ");
                                    xml.Read();
                                    arquivo.WriteLine(xml.Value);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}