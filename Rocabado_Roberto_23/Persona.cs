using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocabado_Roberto_23
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string apellido, string nombre, DateTime nacimiento, string barrioResidencia) :
            this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get 
            {   
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1; 
            }
        }

        public string NombreCompleto
        {
            get { return $"{this.apellido}, {this.nombre}"; } 
        }

        internal abstract string FichaExtra();

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Apellido y Nombre: {this.NombreCompleto}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Fecha de nacimiento: {this.nacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Lugar de residencia: {this.barrioResidencia}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.NombreCompleto}";
        }
    }
}
