using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
   public class UsuarioBE
    {
        public int id { get; set; }
        public string login { get; set; }
        public string   password { get; set; }
        public string nombre { get; set; }
    }
}
