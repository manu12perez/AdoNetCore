namespace AdoNetCore
{
    partial class Form08CrudDepartamentos
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
            lstDepartamentos = new ListBox();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            label4 = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(37, 56);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(405, 304);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 33);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(493, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(193, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(493, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 27);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 88);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(493, 168);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(193, 27);
            txtLocalidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 145);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(493, 261);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(193, 29);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(493, 296);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(193, 29);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(493, 331);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(193, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Label label4;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}