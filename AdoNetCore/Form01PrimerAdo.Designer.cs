namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            label2 = new Label();
            lstTiposDato = new ListBox();
            label3 = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(12, 108);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(115, 29);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(12, 159);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(115, 29);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(12, 208);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(115, 29);
            btnLeerDatos.TabIndex = 2;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 34);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(144, 57);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(172, 244);
            lstApellidos.TabIndex = 4;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(337, 57);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(172, 244);
            lstColumnas.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 34);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.Location = new Point(533, 57);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(172, 244);
            lstTiposDato.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 34);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 7;
            label3.Text = "Tipos Dato";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(33, 327);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 20);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(lstTiposDato);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label label1;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label label2;
        private ListBox lstTiposDato;
        private Label label3;
        private Label lblMensaje;
    }
}
