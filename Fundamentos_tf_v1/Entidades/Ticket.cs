using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_tf_v1.Entities
{
    public class Ticket : Auditoria
    {
        public int IdTicket { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
        public string DispositivoSistema { get; set; }
        public int IdColaborador { get; set; }
        public int? IdTecnico { get; set; }
    }
}