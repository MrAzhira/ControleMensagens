using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Mensagem
    {
        public int IDMensagem { get; set; }
        public Usuario Remetente { get; set; }
        public Usuario Destinatario { get; set; }
        public String Assunto { get; set; }
        public String CorpoMensagem { get; set; }
    }
}
