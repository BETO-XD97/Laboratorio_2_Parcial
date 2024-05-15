namespace Rocabado_Roberto_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMedicos = new Label();
            btnAtender = new Button();
            btnSalir = new Button();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 25);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 0;
            lblMedicos.Text = "Personal Medico";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(506, 328);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(273, 42);
            btnAtender.TabIndex = 2;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(506, 396);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(273, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 43);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(216, 184);
            lstMedicos.TabIndex = 4;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(249, 43);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(251, 184);
            lstPacientes.TabIndex = 5;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 242);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(488, 196);
            rtbInfoMedico.TabIndex = 7;
            rtbInfoMedico.Text = "";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(249, 25);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(52, 15);
            lblPacientes.TabIndex = 1;
            lblPacientes.Text = "Paciente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 450);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedicos;
        private Button btnAtender;
        private Button btnSalir;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private Label lblPacientes;
    }
}
