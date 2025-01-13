namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            btnBuscarEmpleados = new Button();
            label1 = new Label();
            txtSalario = new TextBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            txtOficio = new TextBox();
            label3 = new Label();
            btnBuscarOficio = new Button();
            SuspendLayout();
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(96, 92);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(147, 35);
            btnBuscarEmpleados.TabIndex = 0;
            btnBuscarEmpleados.Text = "Buscar Empleados";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 36);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 1;
            label1.Text = "Introduzca un salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(96, 59);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(147, 27);
            txtSalario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 138);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(96, 161);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(383, 204);
            lstEmpleados.TabIndex = 4;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(319, 59);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(160, 27);
            txtOficio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 36);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 6;
            label3.Text = "Introduzca Oficio";
            // 
            // btnBuscarOficio
            // 
            btnBuscarOficio.Location = new Point(319, 92);
            btnBuscarOficio.Name = "btnBuscarOficio";
            btnBuscarOficio.Size = new Size(160, 35);
            btnBuscarOficio.TabIndex = 7;
            btnBuscarOficio.Text = "Buscar por Oficio";
            btnBuscarOficio.UseVisualStyleBackColor = true;
            btnBuscarOficio.Click += btnBuscarOficio_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarOficio);
            Controls.Add(label3);
            Controls.Add(txtOficio);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Controls.Add(btnBuscarEmpleados);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarEmpleados;
        private Label label1;
        private TextBox txtSalario;
        private Label label2;
        private ListBox lstEmpleados;
        private TextBox txtOficio;
        private Label label3;
        private Button btnBuscarOficio;
    }
}