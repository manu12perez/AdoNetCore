namespace AdoNetCore
{
    partial class Form09CrudHospitales
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtCodHospital = new TextBox();
            label2 = new Label();
            lstHospitales = new ListBox();
            label1 = new Label();
            txtCamas = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(529, 343);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(193, 29);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(304, 343);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(193, 29);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(73, 343);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(193, 29);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(795, 174);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(193, 27);
            txtDireccion.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(795, 151);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 17;
            label4.Text = "Dirección";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(795, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 27);
            txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(795, 94);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 15;
            label3.Text = "Nombre";
            // 
            // txtCodHospital
            // 
            txtCodHospital.Location = new Point(795, 62);
            txtCodHospital.Name = "txtCodHospital";
            txtCodHospital.Size = new Size(193, 27);
            txtCodHospital.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(795, 39);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 13;
            label2.Text = "Código Hospital";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(30, 63);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(721, 264);
            lstHospitales.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(795, 286);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(193, 27);
            txtCamas.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(795, 263);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 24;
            label5.Text = "Camas";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(795, 229);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(193, 27);
            txtTelefono.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(795, 206);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 22;
            label6.Text = "Teléfono";
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 450);
            Controls.Add(txtCamas);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtCodHospital);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtCodHospital;
        private Label label2;
        private ListBox lstHospitales;
        private Label label1;
        private TextBox txtCamas;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
    }
}