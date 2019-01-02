using XML_v2.ModelosXML.Contrato;
using XML_v2.ModelosXML.DesenhoIndustrial;
using XML_v2.ModelosXML.Patente;
using XML_v2.ModelosXML.ProgramaComputador;

namespace XML_v2
{
    public class OrquestradorArquivo
    {
        public void Gerar<T>(object Dados)
        {
            {
                if (typeof(T).Name == typeof(DesenhoIndustrial).Name)
                {
                    MontarArquivoDesenhoIndustrial MontarArquivo = new MontarArquivoDesenhoIndustrial();
                    MontarArquivo.MontarArquivo((DesenhoIndustrial)Dados);
                }
                else if (typeof(T).Name == typeof(Contrato).Name)
                {
                    MontarArquivoContrato MontarArquivo = new MontarArquivoContrato();
                    MontarArquivo.MontarArquivo((Contrato)Dados);
                }
                else if (typeof(T).Name == typeof(Patente).Name)
                {
                    MontarArquivoPatentes MontarArquivo = new MontarArquivoPatentes();
                    MontarArquivo.MontarArquivo((Patente)Dados);
                }
                else if (typeof(T).Name == typeof(ProgramaComputador).Name)
                {
                    MontarArquivoProgramaComputador MontarArquivo = new MontarArquivoProgramaComputador();
                    MontarArquivo.MontarArquivo((ProgramaComputador)Dados);
                }
            }
        }
    }
}
