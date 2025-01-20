namespace AdoNetCore
{
    partial class Form13ParametrosSalida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbDepartamentos = new ComboBox();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSumaSalarial = new TextBox();
            txtMediaSalarial = new TextBox();
            label3 = new Label();
            txtPersonas = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(45, 57);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 1;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(45, 110);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(151, 46);
            btnMostrarDatos.TabIndex = 2;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 198);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 3;
            label2.Text = "Suma Salarial";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(45, 221);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(151, 27);
            txtSumaSalarial.TabIndex = 4;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(45, 286);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(151, 27);
            txtMediaSalarial.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 263);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "Media Salarial";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(45, 357);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(151, 27);
            txtPersonas.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 334);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 7;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 34);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(248, 57);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(233, 344);
            lstEmpleados.TabIndex = 10;
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMediaSalarial);
            Controls.Add(label3);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSumaSalarial;
        private TextBox txtMediaSalarial;
        private Label label3;
        private TextBox txtPersonas;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
    }
}