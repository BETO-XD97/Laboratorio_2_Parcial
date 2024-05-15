using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocabado_Roberto_23
{
    public sealed class Paciente : Persona
    {
        private string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, 
            string barrioResidencia) :
            base(nombre, apellido, nacimiento, barrioResidencia)
        { }

        public string Diagnostico { get { return diagnostico; } set {  diagnostico = value; } } 

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Recide en: {this.barrioResidencia}");
            sb.AppendLine($"{this.Diagnostico}");

            return sb.ToString();
        }


    }
}
