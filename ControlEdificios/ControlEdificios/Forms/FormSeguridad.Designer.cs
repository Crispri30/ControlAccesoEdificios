namespace ControlAccesoPrueba.Forms
{
    partial class FormSeguridad
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
            components = new System.ComponentModel.Container();
            dgvAccesosActivos = new DataGridView();
            timerMonitoreo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvAccesosActivos).BeginInit();
            SuspendLayout();
            // 
            // dgvAccesosActivos
            // 
            dgvAccesosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccesosActivos.Location = new Point(81, 74);
            dgvAccesosActivos.Name = "dgvAccesosActivos";
            dgvAccesosActivos.RowHeadersWidth = 62;
            dgvAccesosActivos.Size = new Size(617, 382);
            dgvAccesosActivos.TabIndex = 0;
            // 
            // timerMonitoreo
            // 
            timerMonitoreo.Enabled = true;
            timerMonitoreo.Interval = 5000;
            timerMonitoreo.Tick += timerMonitoreo_Tick;
            // 
            // FormSeguridad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1143, 750);
            Controls.Add(dgvAccesosActivos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormSeguridad";
            Text = "FormSeguridad";
            Load += FormSeguridad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccesosActivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAccesosActivos;
        private System.Windows.Forms.Timer timerMonitoreo;
    }
}