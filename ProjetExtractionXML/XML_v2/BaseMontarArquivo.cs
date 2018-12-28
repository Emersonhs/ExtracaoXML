using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_v2
{
    public class BaseMontarArquivo
    {
        public StreamWriter arquivo;
        public BaseMontarArquivo(string LocalArquivo)
        {
            arquivo = new StreamWriter(LocalArquivo);
        }
    }
}
