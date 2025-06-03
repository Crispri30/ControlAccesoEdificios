namespace ControlEdificios.Forms
{
    partial class FormReporteAccesos
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
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            dtpHoraDesde = new DateTimePicker();
            dtpHoraHasta = new DateTimePicker();
            cmbPersona = new ComboBox();
            cmbZona = new ComboBox();
            cmbRol = new ComboBox();
            btnFiltrar = new Button();
            dgvReportes = new DataGridView();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            label1 = new Label();
            label2 = new Label();
            lblPersonaFiltro = new Label();
            lblZona = new Label();
            lblRol = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(130, 130);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(227, 23);
            dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(130, 171);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(227, 23);
            dtpHasta.TabIndex = 1;
            // 
            // dtpHoraDesde
            // 
            dtpHoraDesde.CustomFormat = "HH:mm:ss";
            dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            dtpHoraDesde.Location = new Point(130, 210);
            dtpHoraDesde.Name = "dtpHoraDesde";
            dtpHoraDesde.ShowUpDown = true;
            dtpHoraDesde.Size = new Size(70, 23);
            dtpHoraDesde.TabIndex = 2;
            // 
            // dtpHoraHasta
            // 
            dtpHoraHasta.CustomFormat = "HH:mm:ss";
            dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            dtpHoraHasta.Location = new Point(130, 248);
            dtpHoraHasta.Name = "dtpHoraHasta";
            dtpHoraHasta.ShowUpDown = true;
            dtpHoraHasta.Size = new Size(70, 23);
            dtpHoraHasta.TabIndex = 3;
            // 
            // cmbPersona
            // 
            cmbPersona.FormattingEnabled = true;
            cmbPersona.Location = new Point(130, 289);
            cmbPersona.Name = "cmbPersona";
            cmbPersona.Size = new Size(121, 23);
            cmbPersona.TabIndex = 4;
            // 
            // cmbZona
            // 
            cmbZona.FormattingEnabled = true;
            cmbZona.Location = new Point(130, 318);
            cmbZona.Name = "cmbZona";
            cmbZona.Size = new Size(121, 23);
            cmbZona.TabIndex = 5;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(130, 347);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.Bisque;
            btnFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(105, 397);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(179, 66);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.BackgroundColor = SystemColors.ButtonFace;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(389, 130);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(429, 333);
            dgvReportes.TabIndex = 8;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDesde.Location = new Point(38, 136);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(86, 15);
            lblFechaDesde.TabIndex = 9;
            lblFechaDesde.Text = "FECHA DESDE:";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHasta.Location = new Point(38, 177);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(87, 15);
            lblFechaHasta.TabIndex = 10;
            lblFechaHasta.Text = "FECHA HASTA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 216);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 11;
            label1.Text = "HORA DESDE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 254);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 12;
            label2.Text = "HORA HASTA:";
            // 
            // lblPersonaFiltro
            // 
            lblPersonaFiltro.AutoSize = true;
            lblPersonaFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonaFiltro.Location = new Point(38, 292);
            lblPersonaFiltro.Name = "lblPersonaFiltro";
            lblPersonaFiltro.Size = new Size(64, 15);
            lblPersonaFiltro.TabIndex = 13;
            lblPersonaFiltro.Text = "PERSONA:";
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZona.Location = new Point(38, 321);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(43, 15);
            lblZona.TabIndex = 14;
            lblZona.Text = "ZONA:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(46, 357);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(33, 15);
            lblRol.TabIndex = 15;
            lblRol.Text = "ROL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(311, 45);
            label3.Name = "label3";
            label3.Size = new Size(233, 30);
            label3.TabIndex = 16;
            label3.Text = "REPORTE DE ACCESOS";
            // 
            // FormReporteAccesos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(848, 510);
            Controls.Add(label3);
            Controls.Add(lblRol);
            Controls.Add(lblZona);
            Controls.Add(lblPersonaFiltro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFechaHasta);
            Controls.Add(lblFechaDesde);
            Controls.Add(dgvReportes);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbRol);
            Controls.Add(cmbZona);
            Controls.Add(cmbPersona);
            Controls.Add(dtpHoraHasta);
            Controls.Add(dtpHoraDesde);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Name = "FormReporteAccesos";
            Text = "ReporteAccesos";
            Load += FormReporteAccesos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpHoraDesde;
        private DateTimePicker dtpHoraHasta;
        private ComboBox cmbPersona;
        private ComboBox cmbZona;
        private ComboBox cmbRol;
        private Button btnFiltrar;
        private DataGridView dgvReportes;
        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private Label label1;
        private Label label2;
        private Label lblPersonaFiltro;
        private Label lblZona;
        private Label lblRol;
        private Label label3;
    }
}