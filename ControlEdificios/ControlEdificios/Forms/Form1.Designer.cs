namespace ControlAccesoPrueba.Forms
{
    partial class Form1
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
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BttIngresar = new Button();
            lbUsuario = new Label();
            lblContraseña = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(318, 197);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(193, 23);
            TxtUsuario.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(318, 242);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.Size = new Size(193, 23);
            TxtContraseña.TabIndex = 1;
            // 
            // BttIngresar
            // 
            BttIngresar.BackColor = Color.Bisque;
            BttIngresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BttIngresar.Location = new Point(351, 308);
            BttIngresar.Name = "BttIngresar";
            BttIngresar.Size = new Size(114, 60);
            BttIngresar.TabIndex = 2;
            BttIngresar.Text = "INGRESAR";
            BttIngresar.UseVisualStyleBackColor = false;
            BttIngresar.Click += BttIngresar_Click;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(248, 200);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(64, 15);
            lbUsuario.TabIndex = 3;
            lbUsuario.Text = "USUARIO:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(224, 245);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(88, 15);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 44);
            label1.Name = "label1";
            label1.Size = new Size(261, 32);
            label1.TabIndex = 5;
            label1.Text = "CONTROL DE ACCESO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(341, 107);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 6;
            label2.Text = "BIENVENIDO!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblContraseña);
            Controls.Add(lbUsuario);
            Controls.Add(BttIngresar);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button BttIngresar;
        private Label label1;
        private Label label2;
        private Label lbUsuario;
        private Label lblContraseña;
    }
}