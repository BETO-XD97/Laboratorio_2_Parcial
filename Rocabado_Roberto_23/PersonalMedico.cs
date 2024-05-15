using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocabado_Roberto_23
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Finalizo la residencia? {this.esResidente}");
            sb.AppendLine($"Atenciones: \n");
            foreach( var consulta in this.consultas )
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }


        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            if(doctor is not null && paciente is not null)
            {
                Consulta consulta = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(consulta);
                return consulta;
            }

            return new Consulta(DateTime.MinValue, paciente);
        }
    }
}
