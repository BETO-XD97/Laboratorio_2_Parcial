using Rocabado_Roberto_23;
using System.Text;
using System.Windows.Forms;

namespace Rocabado_Roberto_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {               
            if (lstMedicos.SelectedItems == null || lstPacientes.SelectedItems == null)
            {
                MessageBox.Show("Debe seleccionar un Medico o un Paciente para continuar", "Error en los datos!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StringBuilder mensaje = new StringBuilder();
                Consulta c = new Consulta(DateTime.Now, lstPacientes.SelectedItem as Paciente);

                mensaje.AppendLine($"Paciente Curado");
                mensaje.AppendLine($"Medico: {(lstMedicos.SelectedItem as PersonalMedico)}");
                mensaje.AppendLine($"{c.ToString()}");

                if (mensaje is not null)
                {
                    MessageBox.Show(mensaje.ToString(), "Atención finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItems != null)
            {
                PersonalMedico medicoSeleccionado = lstMedicos.SelectedItem as PersonalMedico;
                rtbInfoMedico.Text = medicoSeleccionado.FichaPersonal(medicoSeleccionado);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("Seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Close();
            }

        }
    }
}
