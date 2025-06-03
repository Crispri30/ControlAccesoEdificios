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
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccesosActivos).BeginInit();
            SuspendLayout();
            // 
            // dgvAccesosActivos
            // 
            dgvAccesosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccesosActivos.Location = new Point(94, 66);
            dgvAccesosActivos.Margin = new Padding(2, 2, 2, 2);
            dgvAccesosActivos.Name = "dgvAccesosActivos";
            dgvAccesosActivos.RowHeadersWidth = 62;
            dgvAccesosActivos.Size = new Size(629, 357);
            dgvAccesosActivos.TabIndex = 0;
            // 
            // timerMonitoreo
            // 
            timerMonitoreo.Enabled = true;
            timerMonitoreo.Interval = 5000;
            timerMonitoreo.Tick += timerMonitoreo_Tick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(190, 9);
            label11.Name = "label11";
            label11.Size = new Size(389, 30);
            label11.TabIndex = 26;
            label11.Text = "PANEL MONITOREO EN TIEMPO REAL";
            // 
            // FormSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 449);
            Controls.Add(label11);
            Controls.Add(dgvAccesosActivos);
            Name = "FormSeguridad";
            Text = "FormSeguridad";
            Load += FormSeguridad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccesosActivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAccesosActivos;
        private System.Windows.Forms.Timer timerMonitoreo;
        private Label label11;
    }
}