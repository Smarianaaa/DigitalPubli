using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Proyecto
    {
        public int proyectoId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public string segmentacion { get; set; }
        public int usuarioId { get; set; }
        public Proyecto(int proyectoId, string nombre, string descripcion, string estado, string segmentacion)
        {
            this.proyectoId = proyectoId;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado = estado;
            this.segmentacion = segmentacion;
        }

        public Proyecto()
        {
        }
    }
}
