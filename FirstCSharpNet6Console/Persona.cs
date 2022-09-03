using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpNet6Console
{
    public class Persona
    {
        public int dni { get; set; }
        public string nombreCompleto { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }

        public Persona()
        {

        }
        
        public Persona(int dni, string nombreCompleto, string telefono, bool estado)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.estado = estado;
        }

    }
}
