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
            this.label6 = new System.Windows.Forms.Label();
            this.selectorPantalon = new System.Windows.Forms.CheckedListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectorCamisa = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.historial = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.cotizador.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(284, 561);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // cotizador
            // 
            this.cotizador.Controls.Add(this.label6);
            this.cotizador.Controls.Add(this.selectorPantalon);
            this.cotizador.Controls.Add(this.radioButton2);
            this.cotizador.Controls.Add(this.label5);
            this.cotizador.Controls.Add(this.label4);
            this.cotizador.Controls.Add(this.selectorCamisa);
            this.cotizador.Controls.Add(this.label3);
            this.cotizador.Controls.Add(this.label2);
            this.cotizador.Controls.Add(this.label1);
            this.cotizador.Controls.Add(this.radioButton1);
            this.cotizador.Location = new System.Drawing.Point(4, 24);
            this.cotizador.Name = "cotizador";
            this.cotizador.Padding = new System.Windows.Forms.Padding(3);
            this.cotizador.Size = new System.Drawing.Size(276, 533);
            this.cotizador.TabIndex = 0;
            this.cotizador.Text = "Cotizador";
            this.cotizador.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(0, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 5);
            this.label6.TabIndex = 10;
            // 
            // selectorPantalon
            // 
            this.selectorPantalon.CheckOnClick = true;
            this.selectorPantalon.Enabled = false;
            this.selectorPantalon.FormattingEnabled = true;
            this.selectorPantalon.Items.AddRange(new object[] {
            "Chupin",
            "Comun"});
            this.selectorPantalon.Location = new System.Drawing.Point(10, 227);
            this.selectorPantalon.MultiColumn = true;
            this.selectorPantalon.Name = "selectorPantalon";
            this.selectorPantalon.Size = new System.Drawing.Size(256, 22);
            this.selectorPantalon.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(90, 201);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 30);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PANTALON";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(0, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 5);
            this.label5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(0, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 5);
            this.label4.TabIndex = 4;
            // 
            // selectorCamisa
            // 
            this.selectorCamisa.CheckOnClick = true;
            this.selectorCamisa.Enabled = false;
            this.selectorCamisa.FormattingEnabled = true;
            this.selectorCamisa.Items.AddRange(new object[] {
            "Cuello Mao",
            "Cuello Comun",
            "Manga Corta",
            "Manga Larga"});
            this.selectorCamisa.Location = new System.Drawing.Point(6, 145);
            this.selectorCamisa.MultiColumn = true;
            this.selectorCamisa.Name = "selectorCamisa";
            this.selectorCamisa.Size = new System.Drawing.Size(260, 40);
            this.selectorCamisa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = ".....";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = ".....";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = ".....\r\n.....";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(90, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 30);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CAMISA";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // historial
            // 
            this.historial.Controls.Add(this.dataGridView1);
            this.historial.Location = new System.Drawing.Point(4, 24);
            this.historial.Name = "historial";
            this.historial.Padding = new System.Windows.Forms.Padding(3);
            this.historial.Size = new System.Drawing.Size(276, 533);
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
            this.dataGridView1.Size = new System.Drawing.Size(270, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.cotizador.ResumeLayout(false);
            this.historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage cotizador;
        private TabPage historial;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Label label2;
        private CheckedListBox selectorCamisa;
        private CheckedListBox selectorPantalon;
        private RadioButton radioButton2;
        private Label label5;
        private Label label4;
        private RadioButton radioButton1;
        private Label label6;
    }
}