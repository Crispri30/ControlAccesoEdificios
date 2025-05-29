namespace ControlEdificios.Forms
{
    partial class FormRegistrarAcceso
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
            txtEmpleadoID = new TextBox();
            txtZonaID = new TextBox();
            bttAcceso = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Location = new Point(165, 82);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(100, 23);
            txtEmpleadoID.TabIndex = 0;
            // 
            // txtZonaID
            // 
            txtZonaID.Location = new Point(165, 160);
            txtZonaID.Name = "txtZonaID";
            txtZonaID.Size = new Size(100, 23);
            txtZonaID.TabIndex = 1;
            // 
            // bttAcceso
            // 
            bttAcceso.Location = new Point(165, 235);
            bttAcceso.Name = "bttAcceso";
            bttAcceso.Size = new Size(100, 50);
            bttAcceso.TabIndex = 2;
            bttAcceso.Text = "Registrar Acceso";
            bttAcceso.UseVisualStyleBackColor = true;
            bttAcceso.Click += bttAcceso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 85);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "ID del Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 168);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "ID de la zona";
            // 
            // FormRegistrarAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bttAcceso);
            Controls.Add(txtZonaID);
            Controls.Add(txtEmpleadoID);
            Name = "FormRegistrarAcceso";
            Text = "FormRegistrarAcceso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpleadoID;
        private TextBox txtZonaID;
        private Button bttAcceso;
        private Label label1;
        private Label label2;
    }
}