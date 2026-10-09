using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_tf_v1.Entities
{
    public class Evidencia : Auditoria
    {
        public int IdEvidencia { get; set; }
        public int IdTicket { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }
        public DateTime Fecha { get; set; }
    }
}