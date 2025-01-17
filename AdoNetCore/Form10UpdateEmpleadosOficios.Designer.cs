namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficios
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
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnIncrementarSalarios = new Button();
            label4 = new Label();
            txtOficio = new TextBox();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(63, 50);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(177, 164);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(283, 50);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(177, 244);
            lstEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 27);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 149);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(496, 172);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(125, 27);
            txtIncremento.TabIndex = 5;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(496, 231);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(125, 63);
            btnIncrementarSalarios.TabIndex = 6;
            btnIncrementarSalarios.Text = "Incrementar Salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 27);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(496, 50);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(125, 27);
            txtOficio.TabIndex = 11;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(63, 314);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(112, 20);
            lblSumaSalarial.TabIndex = 7;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(63, 348);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(117, 20);
            lblMediaSalarial.TabIndex = 8;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(63, 384);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(126, 20);
            lblMaximoSalario.TabIndex = 9;
            lblMaximoSalario.Text = "lblMaximoSalario";
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOficio);
            Controls.Add(label4);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnIncrementarSalarios;
        private Label label4;
        private TextBox txtOficio;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalario;
    }
}