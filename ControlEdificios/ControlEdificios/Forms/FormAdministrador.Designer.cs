namespace ControlAccesoPrueba.Forms
{
    partial class FormAdministrador
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
            txtNombre = new TextBox();
            cmbRol = new ComboBox();
            txtID = new TextBox();
            bttAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            bttEliminar = new Button();
            bttActualizar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtIDVis = new TextBox();
            txtNombreVis = new TextBox();
            txtTelefono = new TextBox();
            txtMotivoVisita = new TextBox();
            bttAgregarVis = new Button();
            bttActualizarVis = new Button();
            bttEliminarVis = new Button();
            label11 = new Label();
            label3 = new Label();
            bttAccesos = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 178);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 0;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(148, 232);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(195, 23);
            cmbRol.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(148, 132);
            txtID.Name = "txtID";
            txtID.Size = new Size(195, 23);
            txtID.TabIndex = 2;
            // 
            // bttAgregar
            // 
            bttAgregar.BackColor = Color.Bisque;
            bttAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttAgregar.Location = new Point(39, 276);
            bttAgregar.Name = "bttAgregar";
            bttAgregar.Size = new Size(118, 46);
            bttAgregar.TabIndex = 3;
            bttAgregar.Text = "AGREGAR";
            bttAgregar.UseVisualStyleBackColor = false;
            bttAgregar.Click += bttAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 135);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 5;
            label1.Text = "IDENTIFICACIÓN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 184);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 232);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "ROL:";
            // 
            // bttEliminar
            // 
            bttEliminar.BackColor = Color.Bisque;
            bttEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttEliminar.Location = new Point(129, 328);
            bttEliminar.Name = "bttEliminar";
            bttEliminar.Size = new Size(118, 46);
            bttEliminar.TabIndex = 9;
            bttEliminar.Text = "ELIMINAR";
            bttEliminar.UseVisualStyleBackColor = false;
            bttEliminar.Click += bttEliminar_Click;
            // 
            // bttActualizar
            // 
            bttActualizar.BackColor = Color.Bisque;
            bttActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttActualizar.Location = new Point(215, 276);
            bttActualizar.Name = "bttActualizar";
            bttActualizar.Size = new Size(118, 46);
            bttActualizar.TabIndex = 10;
            bttActualizar.Text = "ACTUALIZAR";
            bttActualizar.UseVisualStyleBackColor = false;
            bttActualizar.Click += bttActualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(97, 74);
            label5.Name = "label5";
            label5.Size = new Size(198, 21);
            label5.TabIndex = 11;
            label5.Text = "GESTIONAR EMPLEADOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(505, 75);
            label6.Name = "label6";
            label6.Size = new Size(182, 20);
            label6.TabIndex = 12;
            label6.Text = "GESTIONAR VISITANTES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(439, 135);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 13;
            label7.Text = "IDENTIFICACIÓN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(439, 184);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(61, 15);
            label8.TabIndex = 14;
            label8.Text = "NOMBRE:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(439, 227);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(68, 15);
            label9.TabIndex = 15;
            label9.Text = "TELÉFONO:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(439, 276);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(98, 15);
            label10.TabIndex = 16;
            label10.Text = "MOTIVO VISITA:";
            // 
            // txtIDVis
            // 
            txtIDVis.Location = new Point(559, 132);
            txtIDVis.Name = "txtIDVis";
            txtIDVis.Size = new Size(197, 23);
            txtIDVis.TabIndex = 17;
            // 
            // txtNombreVis
            // 
            txtNombreVis.Location = new Point(559, 178);
            txtNombreVis.Name = "txtNombreVis";
            txtNombreVis.Size = new Size(197, 23);
            txtNombreVis.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(559, 224);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(197, 23);
            txtTelefono.TabIndex = 19;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtMotivoVisita
            // 
            txtMotivoVisita.Location = new Point(559, 273);
            txtMotivoVisita.Name = "txtMotivoVisita";
            txtMotivoVisita.Size = new Size(197, 23);
            txtMotivoVisita.TabIndex = 20;
            // 
            // bttAgregarVis
            // 
            bttAgregarVis.BackColor = Color.Bisque;
            bttAgregarVis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttAgregarVis.Location = new Point(439, 326);
            bttAgregarVis.Name = "bttAgregarVis";
            bttAgregarVis.Size = new Size(118, 46);
            bttAgregarVis.TabIndex = 21;
            bttAgregarVis.Text = "AGREGAR";
            bttAgregarVis.UseVisualStyleBackColor = false;
            bttAgregarVis.Click += bttAgregarVis_Click;
            // 
            // bttActualizarVis
            // 
            bttActualizarVis.BackColor = Color.Bisque;
            bttActualizarVis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttActualizarVis.Location = new Point(638, 326);
            bttActualizarVis.Name = "bttActualizarVis";
            bttActualizarVis.Size = new Size(118, 46);
            bttActualizarVis.TabIndex = 22;
            bttActualizarVis.Text = "ACTUALIZAR";
            bttActualizarVis.UseVisualStyleBackColor = false;
            bttActualizarVis.Click += bttActualizarVis_Click;
            // 
            // bttEliminarVis
            // 
            bttEliminarVis.BackColor = Color.Bisque;
            bttEliminarVis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttEliminarVis.Location = new Point(537, 378);
            bttEliminarVis.Name = "bttEliminarVis";
            bttEliminarVis.Size = new Size(118, 46);
            bttEliminarVis.TabIndex = 23;
            bttEliminarVis.Text = "ELIMINAR";
            bttEliminarVis.UseVisualStyleBackColor = false;
            bttEliminarVis.Click += bttEliminarVis_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(273, 20);
            label11.Name = "label11";
            label11.Size = new Size(264, 30);
            label11.TabIndex = 24;
            label11.Text = "PANEL ADMINISTRADOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 409);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 25;
            label3.Text = "REGISTRAR ACCESOS:";
            // 
            // bttAccesos
            // 
            bttAccesos.BackColor = Color.Bisque;
            bttAccesos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttAccesos.Location = new Point(177, 392);
            bttAccesos.Name = "bttAccesos";
            bttAccesos.Size = new Size(118, 46);
            bttAccesos.TabIndex = 26;
            bttAccesos.Text = "ACCESOS";
            bttAccesos.UseVisualStyleBackColor = false;
            bttAccesos.Click += bttAccesos_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(bttAccesos);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(bttEliminarVis);
            Controls.Add(bttActualizarVis);
            Controls.Add(bttAgregarVis);
            Controls.Add(txtMotivoVisita);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombreVis);
            Controls.Add(txtIDVis);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(bttActualizar);
            Controls.Add(bttEliminar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bttAgregar);
            Controls.Add(txtID);
            Controls.Add(cmbRol);
            Controls.Add(txtNombre);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            Load += FormAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ComboBox cmbRol;
        private TextBox txtID;
        private Button bttAgregar;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button bttEliminar;
        private Button bttActualizar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtIDVis;
        private TextBox txtNombreVis;
        private TextBox txtTelefono;
        private TextBox txtMotivoVisita;
        private Button bttAgregarVis;
        private Button bttActualizarVis;
        private Button bttEliminarVis;
        private Label label11;
        private Label label3;
        private Button bttAccesos;
    }
}