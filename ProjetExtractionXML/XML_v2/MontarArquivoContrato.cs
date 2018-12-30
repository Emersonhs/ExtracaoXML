using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_v2.Model;

namespace XML_v2
{
    public class MontarArquivoContrato : BaseMontarArquivo
    {
        public MontarArquivoContrato() : base(Constantes.Arquivos.ContratoSaida)
        {
        }
        public void MontarAquivo(Contrato contrato)
        {
            arquivo.WriteLine("No " + contrato.numero + " de " + contrato.dataPublicacao);
            arquivo.WriteLine("|");
            arquivo.WriteLine("No " + contrato.numero + " de " + contrato.dataPublicacao);

            //foreach (var ItemDespacho in contrato.despacho)
            //{
            //    arquivo.WriteLine("(Cd) " + ItemDespacho.codigo.ToString().Replace('.', ','));
            //    if (ItemDespacho.processo-contrato != null)
            //    {
            //        if (ItemDespacho.numero != null)
            //        {
            //            arquivo.WriteLine("(" + ItemDespacho.processo-contrato.numero.inid + ") " + ItemDespacho.processopatente.numero.Value);
            //        }
            //        else if (ItemDespacho.cedentes != null)
            //        {
            //            arquivo.WriteLine("(" + ItemDespacho.nomeCompleto.numero.inid + ") " + ItemDespacho.nomeCompleto.numero.Value);
            //        }
            //        else if (ItemDespacho.cessionarias != null)
            //        {
            //            arquivo.WriteLine("(" + ItemDespacho.nomeCompleto.numero.inid + ") " + ItemDespacho.nomeCompleto.numero.Value);
            //        }
            //    }
            //}
            arquivo.Close();
        }
    }
}
