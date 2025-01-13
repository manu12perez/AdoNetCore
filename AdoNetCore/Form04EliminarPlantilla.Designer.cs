namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            lstPlantillas = new ListBox();
            label2 = new Label();
            btnEliminarPlantilla = new Button();
            txtIdEmpleado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstPlantillas
            // 
            lstPlantillas.FormattingEnabled = true;
            lstPlantillas.Location = new Point(344, 73);
            lstPlantillas.Name = "lstPlantillas";
            lstPlantillas.Size = new Size(248, 204);
            lstPlantillas.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 50);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 8;
            label2.Text = "Plantillas";
            // 
            // btnEliminarPlantilla
            // 
            btnEliminarPlantilla.Location = new Point(88, 212);
            btnEliminarPlantilla.Name = "btnEliminarPlantilla";
            btnEliminarPlantilla.Size = new Size(213, 65);
            btnEliminarPlantilla.TabIndex = 7;
            btnEliminarPlantilla.Text = "Eliminar Plantilla";
            btnEliminarPlantilla.UseVisualStyleBackColor = true;
            btnEliminarPlantilla.Click += btnEliminarPlantilla_Click;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(88, 73);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(213, 27);
            txtIdEmpleado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 50);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 5;
            label1.Text = "Id Empleado";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPlantillas);
            Controls.Add(label2);
            Controls.Add(btnEliminarPlantilla);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPlantillas;
        private Label label2;
        private Button btnEliminarPlantilla;
        private TextBox txtIdEmpleado;
        private Label label1;
    }
}