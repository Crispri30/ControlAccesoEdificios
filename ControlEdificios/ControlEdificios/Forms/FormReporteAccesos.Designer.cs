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
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(78, 72);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(227, 23);
            dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(78, 101);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(227, 23);
            dtpHasta.TabIndex = 1;
            // 
            // dtpHoraDesde
            // 
            dtpHoraDesde.CustomFormat = "HH:mm:ss";
            dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            dtpHoraDesde.Location = new Point(235, 130);
            dtpHoraDesde.Name = "dtpHoraDesde";
            dtpHoraDesde.ShowUpDown = true;
            dtpHoraDesde.Size = new Size(70, 23);
            dtpHoraDesde.TabIndex = 2;
            // 
            // dtpHoraHasta
            // 
            dtpHoraHasta.CustomFormat = "HH:mm:ss";
            dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            dtpHoraHasta.Location = new Point(235, 159);
            dtpHoraHasta.Name = "dtpHoraHasta";
            dtpHoraHasta.ShowUpDown = true;
            dtpHoraHasta.Size = new Size(70, 23);
            dtpHoraHasta.TabIndex = 3;
            // 
            // cmbPersona
            // 
            cmbPersona.FormattingEnabled = true;
            cmbPersona.Location = new Point(79, 212);
            cmbPersona.Name = "cmbPersona";
            cmbPersona.Size = new Size(121, 23);
            cmbPersona.TabIndex = 4;
            // 
            // cmbZona
            // 
            cmbZona.FormattingEnabled = true;
            cmbZona.Location = new Point(79, 241);
            cmbZona.Name = "cmbZona";
            cmbZona.Size = new Size(121, 23);
            cmbZona.TabIndex = 5;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(79, 270);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(118, 335);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(409, 116);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(352, 274);
            dgvReportes.TabIndex = 8;
            // 
            // FormReporteAccesos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
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
    }
}