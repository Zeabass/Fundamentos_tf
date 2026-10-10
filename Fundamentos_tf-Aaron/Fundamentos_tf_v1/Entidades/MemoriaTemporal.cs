using Fundamentos_tf_v1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_tf_v1.Entidades
{
    public static class MemoriaTemporal
    {
        public static Usuario UsuarioActual { get; set; }
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static List<Ticket> Tickets = new List<Ticket>
        {
            new Ticket
            {
                IdTicket = 1,
                Titulo = "Falla de red",
                Descripcion = "Sin internet",
                Categoria = "Redes",
                Prioridad = "Alta",
                Estado = "Registrado",
                IdColaborador = 1003,
                CreadoPor = 1003,
                CreadoTiempo = DateTime.Now
            }
        };
        public static List<HistorialAtencion> Historiales = new List<HistorialAtencion>();

    };
}

