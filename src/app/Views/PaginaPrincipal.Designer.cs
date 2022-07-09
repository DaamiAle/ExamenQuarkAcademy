namespace ExamenQuarkAcademy.src.app.Views
{
    partial class PaginaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cotizador = new System.Windows.Forms.TabPage();
            this.historial = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cotizador);
            this.tabControl1.Controls.Add(this.historial);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // cotizador
            // 
            this.cotizador.Location = new System.Drawing.Point(4, 24);
            this.cotizador.Name = "cotizador";
            this.cotizador.Padding = new System.Windows.Forms.Padding(3);
            this.cotizador.Size = new System.Drawing.Size(276, 433);
            this.cotizador.TabIndex = 0;
            this.cotizador.Text = "Cotizador";
            this.cotizador.UseVisualStyleBackColor = true;
            // 
            // historial
            // 
            this.historial.Controls.Add(this.dataGridView1);
            this.historial.Location = new System.Drawing.Point(4, 24);
            this.historial.Name = "historial";
            this.historial.Padding = new System.Windows.Forms.Padding(3);
            this.historial.Size = new System.Drawing.Size(276, 433);
            this.historial.TabIndex = 1;
            this.historial.Text = "Historial";
            this.historial.UseVisualStyleBackColor = true;
            this.historial.Click += new System.EventHandler(this.historial_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(270, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaginaPrincipal_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage cotizador;
        private TabPage historial;
        private DataGridView dataGridView1;
    }
}