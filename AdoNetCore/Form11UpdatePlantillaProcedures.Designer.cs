namespace AdoNetCore
{
    partial class Form11UpdatePlantillaProcedures
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
            cmbHospital = new ComboBox();
            btnModificarSalarios = new Button();
            label2 = new Label();
            txtIncremento = new TextBox();
            label3 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospital
            // 
            cmbHospital.FormattingEnabled = true;
            cmbHospital.Location = new Point(49, 48);
            cmbHospital.Name = "cmbHospital";
            cmbHospital.Size = new Size(245, 28);
            cmbHospital.TabIndex = 1;
            cmbHospital.SelectedIndexChanged += cmbHospital_SelectedIndexChanged;
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(294, 108);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(143, 40);
            btnModificarSalarios.TabIndex = 2;
            btnModificarSalarios.Text = "Modificar salarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 25);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(433, 49);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(245, 27);
            txtIncremento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 170);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(49, 193);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(629, 184);
            lstPlantilla.TabIndex = 6;
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(btnModificarSalarios);
            Controls.Add(cmbHospital);
            Controls.Add(label1);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospital;
        private Button btnModificarSalarios;
        private Label label2;
        private TextBox txtIncremento;
        private Label label3;
        private ListBox lstPlantilla;
    }
}