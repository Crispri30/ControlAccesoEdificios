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
            label3 = new Label();
            label4 = new Label();
            txtVisitanteID = new TextBox();
            txtZonaVis = new TextBox();
            button1 = new Button();
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
            bttAcceso.Location = new Point(99, 227);
            bttAcceso.Name = "bttAcceso";
            bttAcceso.Size = new Size(166, 62);
            bttAcceso.TabIndex = 2;
            bttAcceso.Text = "Registrar Acceso de Empleado";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 90);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "ID del Visitante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 168);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "ID de la zona";
            // 
            // txtVisitanteID
            // 
            txtVisitanteID.Location = new Point(518, 87);
            txtVisitanteID.Name = "txtVisitanteID";
            txtVisitanteID.Size = new Size(100, 23);
            txtVisitanteID.TabIndex = 7;
            // 
            // txtZonaVis
            // 
            txtZonaVis.Location = new Point(518, 160);
            txtZonaVis.Name = "txtZonaVis";
            txtZonaVis.Size = new Size(100, 23);
            txtZonaVis.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(452, 227);
            button1.Name = "button1";
            button1.Size = new Size(166, 62);
            button1.TabIndex = 9;
            button1.Text = "Registrar Acceso de Visitante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRegistrarAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtZonaVis);
            Controls.Add(txtVisitanteID);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox txtVisitanteID;
        private TextBox txtZonaVis;
        private Button button1;
    }
}