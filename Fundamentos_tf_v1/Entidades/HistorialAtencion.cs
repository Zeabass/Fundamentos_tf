using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_tf_v1.Entities
{
    public class HistorialAtencion : Auditoria
    {
        public int IdHistorial { get; set; }
        public int IdTicket { get; set; }
        public int IdTecnico { get; set; }
        public string Comentario { get; set; }
        public string Solucion { get; set; }
        public DateTime FechaAtencion { get; set; }
    }
}