using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio_Legal.CORE.Domain
{
    #nullable disable
    public class Telefone
    {
        public string Numero { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}