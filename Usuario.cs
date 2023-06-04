using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Usuario
    {
        public int usuarioId { get; set; }
        public String nombre { get; set; }
        public String nombreUsuario { get; set; }
        public String tipo { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }
        public String celular { get; set; }
        public String direccion { get; set; }
        public String password { get; set; }

        public Usuario(int usuarioId, string nombre, string nombreUsuario, string tipo, string correo, string telefono, string celular, string direccion, string password)
        {
            this.usuarioId = usuarioId;
            this.nombre = nombre;
            this.nombreUsuario = nombreUsuario;
            this.tipo = tipo;
            this.correo = correo;
            this.telefono = telefono;
            this.celular = celular;
            this.direccion = direccion;
            this.password = password;
        }

        public Usuario()
        {
            
        }

    }
}
