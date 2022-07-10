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
            this.verificadorStock = new System.Windows.Forms.Button();
            this.stockDisponible = new System.Windows.Forms.Label();
            this.verificadorPremium = new System.Windows.Forms.CheckBox();
            this.verificadorChupin = new System.Windows.Forms.CheckBox();
            this.selectorCuello = new System.Windows.Forms.ComboBox();
            this.selectorManga = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectorPantalon = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorCamisa = new System.Windows.Forms.RadioButton();
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
            this.cotizador.Controls.Add(this.verificadorStock);
            this.cotizador.Controls.Add(this.stockDisponible);
            this.cotizador.Controls.Add(this.verificadorPremium);
            this.cotizador.Controls.Add(this.verificadorChupin);
            this.cotizador.Controls.Add(this.selectorCuello);
            this.cotizador.Controls.Add(this.selectorManga);
            this.cotizador.Controls.Add(this.label6);
            this.cotizador.Controls.Add(this.selectorPantalon);
            this.cotizador.Controls.Add(this.label5);
            this.cotizador.Controls.Add(this.label4);
            this.cotizador.Controls.Add(this.label3);
            this.cotizador.Controls.Add(this.label2);
            this.cotizador.Controls.Add(this.label1);
            this.cotizador.Controls.Add(this.selectorCamisa);
            this.cotizador.Location = new System.Drawing.Point(4, 24);
            this.cotizador.Name = "cotizador";
            this.cotizador.Padding = new System.Windows.Forms.Padding(3);
            this.cotizador.Size = new System.Drawing.Size(276, 533);
            this.cotizador.TabIndex = 0;
            this.cotizador.Text = "Cotizador";
            this.cotizador.UseVisualStyleBackColor = true;
            // 
            // verificadorStock
            // 
            this.verificadorStock.Location = new System.Drawing.Point(38, 270);
            this.verificadorStock.Name = "verificadorStock";
            this.verificadorStock.Size = new System.Drawing.Size(200, 30);
            this.verificadorStock.TabIndex = 16;
            this.verificadorStock.Text = "Verificar Disponibilidad";
            this.verificadorStock.UseVisualStyleBackColor = true;
            this.verificadorStock.Click += new System.EventHandler(this.verificadorStock_Click);
            // 
            // stockDisponible
            // 
            this.stockDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockDisponible.Location = new System.Drawing.Point(140, 230);
            this.stockDisponible.Name = "stockDisponible";
            this.stockDisponible.Size = new System.Drawing.Size(120, 30);
            this.stockDisponible.TabIndex = 15;
            this.stockDisponible.Text = "Stock disponible:";
            this.stockDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // verificadorPremium
            // 
            this.verificadorPremium.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.verificadorPremium.Location = new System.Drawing.Point(10, 230);
            this.verificadorPremium.Name = "verificadorPremium";
            this.verificadorPremium.Size = new System.Drawing.Size(120, 30);
            this.verificadorPremium.TabIndex = 14;
            this.verificadorPremium.Text = "Calidad Premium";
            this.verificadorPremium.UseVisualStyleBackColor = true;
            // 
            // verificadorChupin
            // 
            this.verificadorChupin.AutoSize = true;
            this.verificadorChupin.Enabled = false;
            this.verificadorChupin.Location = new System.Drawing.Point(176, 160);
            this.verificadorChupin.Name = "verificadorChupin";
            this.verificadorChupin.Size = new System.Drawing.Size(65, 19);
            this.verificadorChupin.TabIndex = 13;
            this.verificadorChupin.Text = "Chupin";
            this.verificadorChupin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.verificadorChupin.UseVisualStyleBackColor = true;
            // 
            // selectorCuello
            // 
            this.selectorCuello.Enabled = false;
            this.selectorCuello.FormattingEnabled = true;
            this.selectorCuello.Items.AddRange(new object[] {
            "Mao",
            "Comun"});
            this.selectorCuello.Location = new System.Drawing.Point(10, 180);
            this.selectorCuello.Name = "selectorCuello";
            this.selectorCuello.Size = new System.Drawing.Size(121, 23);
            this.selectorCuello.TabIndex = 12;
            this.selectorCuello.Text = "Cuello";
            // 
            // selectorManga
            // 
            this.selectorManga.Enabled = false;
            this.selectorManga.FormattingEnabled = true;
            this.selectorManga.Items.AddRange(new object[] {
            "Corta",
            "Larga"});
            this.selectorManga.Location = new System.Drawing.Point(10, 150);
            this.selectorManga.Name = "selectorManga";
            this.selectorManga.Size = new System.Drawing.Size(121, 23);
            this.selectorManga.TabIndex = 11;
            this.selectorManga.Text = "Manga";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(135, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(6, 100);
            this.label6.TabIndex = 10;
            // 
            // selectorPantalon
            // 
            this.selectorPantalon.Location = new System.Drawing.Point(176, 120);
            this.selectorPantalon.Name = "selectorPantalon";
            this.selectorPantalon.Size = new System.Drawing.Size(86, 30);
            this.selectorPantalon.TabIndex = 8;
            this.selectorPantalon.TabStop = true;
            this.selectorPantalon.Text = "PANTALON";
            this.selectorPantalon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectorPantalon.UseVisualStyleBackColor = true;
            this.selectorPantalon.CheckedChanged += new System.EventHandler(this.selectorPantalon_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(0, 210);
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
            // selectorCamisa
            // 
            this.selectorCamisa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectorCamisa.Location = new System.Drawing.Point(10, 120);
            this.selectorCamisa.Name = "selectorCamisa";
            this.selectorCamisa.Size = new System.Drawing.Size(86, 30);
            this.selectorCamisa.TabIndex = 7;
            this.selectorCamisa.TabStop = true;
            this.selectorCamisa.Text = "CAMISA";
            this.selectorCamisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectorCamisa.UseVisualStyleBackColor = true;
            this.selectorCamisa.CheckedChanged += new System.EventHandler(this.selectorCamisa_CheckedChanged);
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
            this.cotizador.PerformLayout();
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
        private RadioButton selectorPantalon;
        private Label label5;
        private Label label4;
        private RadioButton selectorCamisa;
        private Label label6;
        private ComboBox selectorCuello;
        private ComboBox selectorManga;
        private CheckBox verificadorChupin;
        private CheckBox verificadorPremium;
        private Label stockDisponible;
        private Button verificadorStock;
    }
}