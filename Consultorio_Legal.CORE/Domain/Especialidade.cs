using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio_Legal.CORE.Domain
{
    #nullable disable
    public class Especialidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Medico> Medicos { get; set; }
    }
}