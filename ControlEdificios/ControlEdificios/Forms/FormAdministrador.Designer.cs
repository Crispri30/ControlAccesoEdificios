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
            button1 = new Button();
            label12 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 297);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 31);
            txtNombre.TabIndex = 0;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(211, 387);
            cmbRol.Margin = new Padding(4, 5, 4, 5);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(277, 33);
            cmbRol.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(211, 220);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(277, 31);
            txtID.TabIndex = 2;
            // 
            // bttAgregar
            // 
            bttAgregar.BackColor = Color.Bisque;
            bttAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttAgregar.Location = new Point(56, 460);
            bttAgregar.Margin = new Padding(4, 5, 4, 5);
            bttAgregar.Name = "bttAgregar";
            bttAgregar.Size = new Size(181, 36);
            bttAgregar.TabIndex = 3;
            bttAgregar.Text = "AGREGAR";
            bttAgregar.UseVisualStyleBackColor = false;
            bttAgregar.Click += bttAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 225);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 5;
            label1.Text = "IDENTIFICACIÓN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 307);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(96, 25);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 387);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(52, 25);
            label4.TabIndex = 8;
            label4.Text = "ROL:";
            // 
            // bttEliminar
            // 
            bttEliminar.BackColor = Color.Bisque;
            bttEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttEliminar.Location = new Point(190, 524);
            bttEliminar.Margin = new Padding(4, 5, 4, 5);
            bttEliminar.Name = "bttEliminar";
            bttEliminar.Size = new Size(181, 36);
            bttEliminar.TabIndex = 9;
            bttEliminar.Text = "ELIMINAR";
            bttEliminar.UseVisualStyleBackColor = false;
            bttEliminar.Click += bttEliminar_Click;
            // 
            // bttActualizar
            // 
            bttActualizar.BackColor = Color.Bisque;
            bttActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttActualizar.Location = new Point(307, 460);
            bttActualizar.Margin = new Padding(4, 5, 4, 5);
            bttActualizar.Name = "bttActualizar";
            bttActualizar.Size = new Size(181, 36);
            bttActualizar.TabIndex = 10;
            bttActualizar.Text = "ACTUALIZAR";
            bttActualizar.UseVisualStyleBackColor = false;
            bttActualizar.Click += bttActualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 123);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(298, 32);
            label5.TabIndex = 11;
            label5.Text = "GESTIONAR EMPLEADOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(721, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(272, 31);
            label6.TabIndex = 12;
            label6.Text = "GESTIONAR VISITANTES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(627, 225);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 13;
            label7.Text = "IDENTIFICACIÓN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(627, 307);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(96, 25);
            label8.TabIndex = 14;
            label8.Text = "NOMBRE:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(627, 378);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(108, 25);
            label9.TabIndex = 15;
            label9.Text = "TELÉFONO:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(627, 460);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(152, 25);
            label10.TabIndex = 16;
            label10.Text = "MOTIVO VISITA:";
            // 
            // txtIDVis
            // 
            txtIDVis.Location = new Point(799, 220);
            txtIDVis.Margin = new Padding(4, 5, 4, 5);
            txtIDVis.Name = "txtIDVis";
            txtIDVis.Size = new Size(280, 31);
            txtIDVis.TabIndex = 17;
            // 
            // txtNombreVis
            // 
            txtNombreVis.Location = new Point(799, 297);
            txtNombreVis.Margin = new Padding(4, 5, 4, 5);
            txtNombreVis.Name = "txtNombreVis";
            txtNombreVis.Size = new Size(280, 31);
            txtNombreVis.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(799, 373);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(280, 31);
            txtTelefono.TabIndex = 19;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtMotivoVisita
            // 
            txtMotivoVisita.Location = new Point(799, 455);
            txtMotivoVisita.Margin = new Padding(4, 5, 4, 5);
            txtMotivoVisita.Name = "txtMotivoVisita";
            txtMotivoVisita.Size = new Size(280, 31);
            txtMotivoVisita.TabIndex = 20;
            // 
            // bttAgregarVis
            // 
            bttAgregarVis.BackColor = Color.Bisque;
            bttAgregarVis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttAgregarVis.Location = new Point(627, 543);
            bttAgregarVis.Margin = new Padding(4, 5, 4, 5);
            bttAgregarVis.Name = "bttAgregarVis";
            bttAgregarVis.Size = new Size(181, 36);
            bttAgregarVis.TabIndex = 21;
            bttAgregarVis.Text = "AGREGAR";
            bttAgregarVis.UseVisualStyleBackColor = false;
            bttAgregarVis.Click += bttAgregarVis_Click;
            // 
            // bttActualizarVis
            // 
            bttActualizarVis.BackColor = Color.Bisque;
            bttActualizarVis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttActualizarVis.Location = new Point(911, 543);
            bttActualizarVis.Margin = new Padding(4, 5, 4, 5);
            bttActualizarVis.Name = "bttActualizarVis";
            bttActualizarVis.Size = new Size(181, 36);
            bttActualizarVis.TabIndex = 22;
            bttActualizarVis.Text = "ACTUALIZAR";
            bttActualizarVis.UseVisualStyleBackColor = false;
            bttActualizarVis.Click += bttActualizarVis_Click;
            // 
            // bttEliminarVis
            // 
            bttEliminarVis.BackColor = Color.Bisque;
            bttEliminarVis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttEliminarVis.Location = new Point(773, 607);
            bttEliminarVis.Margin = new Padding(4, 5, 4, 5);
            bttEliminarVis.Name = "bttEliminarVis";
            bttEliminarVis.Size = new Size(181, 36);
            bttEliminarVis.TabIndex = 23;
            bttEliminarVis.Text = "ELIMINAR";
            bttEliminarVis.UseVisualStyleBackColor = false;
            bttEliminarVis.Click += bttEliminarVis_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(390, 33);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(401, 45);
            label11.TabIndex = 24;
            label11.Text = "PANEL ADMINISTRADOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 682);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(199, 25);
            label3.TabIndex = 25;
            label3.Text = "REGISTRAR ACCESOS:";
            // 
            // bttAccesos
            // 
            bttAccesos.BackColor = Color.Bisque;
            bttAccesos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttAccesos.Location = new Point(253, 653);
            bttAccesos.Margin = new Padding(4, 5, 4, 5);
            bttAccesos.Name = "bttAccesos";
            bttAccesos.Size = new Size(169, 77);
            bttAccesos.TabIndex = 26;
            bttAccesos.Text = "ACCESOS";
            bttAccesos.UseVisualStyleBackColor = false;
            bttAccesos.Click += bttAccesos_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(807, 655);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(169, 77);
            button1.TabIndex = 28;
            button1.Text = "MONITOREO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(480, 682);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(319, 25);
            label12.TabIndex = 27;
            label12.Text = "VER MONITOREO EN TIEMPO REAL:";
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(label12);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button1;
        private Label label12;
    }
}