using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_tf_v1.Entities
{
    public abstract class Auditoria
    {
        public int CreadoPor { get; set; }
        public DateTime CreadoTiempo { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? ModificadoEn { get; set; }
    }
}
