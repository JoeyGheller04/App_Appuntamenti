
namespace App_Appuntamenti
{
    partial class frm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAppuntamenti = new System.Windows.Forms.Button();
            this.btnPazienti = new System.Windows.Forms.Button();
            this.btnSpecializzazioni = new System.Windows.Forms.Button();
            this.btnPatologie = new System.Windows.Forms.Button();
            this.btnMedici = new System.Windows.Forms.Button();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbp1 = new System.Windows.Forms.TabPage();
            this.dgwMedici = new System.Windows.Forms.DataGridView();
            this.tbp2 = new System.Windows.Forms.TabPage();
            this.dgwPatologie = new System.Windows.Forms.DataGridView();
            this.tbp3 = new System.Windows.Forms.TabPage();
            this.dgwSpecializzazioni = new System.Windows.Forms.DataGridView();
            this.tbp4 = new System.Windows.Forms.TabPage();
            this.dgwPazienti = new System.Windows.Forms.DataGridView();
            this.tbp5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.ckbPaziente = new System.Windows.Forms.CheckBox();
            this.ckbMedico = new System.Windows.Forms.CheckBox();
            this.ckbData = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaziente = new System.Windows.Forms.ComboBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbData = new System.Windows.Forms.DateTimePicker();
            this.dgwAppuntamenti = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedici)).BeginInit();
            this.tbp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatologie)).BeginInit();
            this.tbp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSpecializzazioni)).BeginInit();
            this.tbp4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPazienti)).BeginInit();
            this.tbp5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppuntamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnAppuntamenti);
            this.panel1.Controls.Add(this.btnPazienti);
            this.panel1.Controls.Add(this.btnSpecializzazioni);
            this.panel1.Controls.Add(this.btnPatologie);
            this.panel1.Controls.Add(this.btnMedici);
            this.panel1.Location = new System.Drawing.Point(-11, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 478);
            this.panel1.TabIndex = 0;
            // 
            // btnAppuntamenti
            // 
            this.btnAppuntamenti.BackColor = System.Drawing.Color.Gray;
            this.btnAppuntamenti.FlatAppearance.BorderSize = 0;
            this.btnAppuntamenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnAppuntamenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppuntamenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppuntamenti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAppuntamenti.Location = new System.Drawing.Point(3, 305);
            this.btnAppuntamenti.Name = "btnAppuntamenti";
            this.btnAppuntamenti.Size = new System.Drawing.Size(137, 42);
            this.btnAppuntamenti.TabIndex = 4;
            this.btnAppuntamenti.Text = "Appuntamenti";
            this.btnAppuntamenti.UseVisualStyleBackColor = false;
            this.btnAppuntamenti.Click += new System.EventHandler(this.btnAppuntamenti_Click);
            // 
            // btnPazienti
            // 
            this.btnPazienti.BackColor = System.Drawing.Color.Gray;
            this.btnPazienti.FlatAppearance.BorderSize = 0;
            this.btnPazienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnPazienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPazienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPazienti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPazienti.Location = new System.Drawing.Point(0, 257);
            this.btnPazienti.Name = "btnPazienti";
            this.btnPazienti.Size = new System.Drawing.Size(137, 42);
            this.btnPazienti.TabIndex = 3;
            this.btnPazienti.Text = "Pazienti";
            this.btnPazienti.UseVisualStyleBackColor = false;
            this.btnPazienti.Click += new System.EventHandler(this.btnPazienti_Click);
            // 
            // btnSpecializzazioni
            // 
            this.btnSpecializzazioni.BackColor = System.Drawing.Color.Gray;
            this.btnSpecializzazioni.FlatAppearance.BorderSize = 0;
            this.btnSpecializzazioni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSpecializzazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecializzazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecializzazioni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpecializzazioni.Location = new System.Drawing.Point(0, 209);
            this.btnSpecializzazioni.Name = "btnSpecializzazioni";
            this.btnSpecializzazioni.Size = new System.Drawing.Size(137, 42);
            this.btnSpecializzazioni.TabIndex = 2;
            this.btnSpecializzazioni.Text = "Special.";
            this.btnSpecializzazioni.UseVisualStyleBackColor = false;
            this.btnSpecializzazioni.Click += new System.EventHandler(this.btnSpecializzazioni_Click);
            // 
            // btnPatologie
            // 
            this.btnPatologie.BackColor = System.Drawing.Color.Gray;
            this.btnPatologie.FlatAppearance.BorderSize = 0;
            this.btnPatologie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnPatologie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatologie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatologie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPatologie.Location = new System.Drawing.Point(3, 161);
            this.btnPatologie.Name = "btnPatologie";
            this.btnPatologie.Size = new System.Drawing.Size(137, 42);
            this.btnPatologie.TabIndex = 1;
            this.btnPatologie.Text = "Patologie";
            this.btnPatologie.UseVisualStyleBackColor = false;
            this.btnPatologie.Click += new System.EventHandler(this.btnPatologie_Click);
            // 
            // btnMedici
            // 
            this.btnMedici.BackColor = System.Drawing.Color.Gray;
            this.btnMedici.FlatAppearance.BorderSize = 0;
            this.btnMedici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnMedici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMedici.Location = new System.Drawing.Point(3, 113);
            this.btnMedici.Name = "btnMedici";
            this.btnMedici.Size = new System.Drawing.Size(137, 42);
            this.btnMedici.TabIndex = 0;
            this.btnMedici.Text = "Medici";
            this.btnMedici.UseVisualStyleBackColor = false;
            this.btnMedici.Click += new System.EventHandler(this.btnMedici_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbp1);
            this.tbc.Controls.Add(this.tbp2);
            this.tbc.Controls.Add(this.tbp3);
            this.tbc.Controls.Add(this.tbp4);
            this.tbc.Controls.Add(this.tbp5);
            this.tbc.Location = new System.Drawing.Point(115, -24);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(697, 510);
            this.tbc.TabIndex = 1;
            // 
            // tbp1
            // 
            this.tbp1.Controls.Add(this.dgwMedici);
            this.tbp1.Location = new System.Drawing.Point(4, 22);
            this.tbp1.Name = "tbp1";
            this.tbp1.Padding = new System.Windows.Forms.Padding(3);
            this.tbp1.Size = new System.Drawing.Size(689, 470);
            this.tbp1.TabIndex = 0;
            this.tbp1.Text = "Medici";
            this.tbp1.UseVisualStyleBackColor = true;
            // 
            // dgwMedici
            // 
            this.dgwMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedici.Location = new System.Drawing.Point(0, 0);
            this.dgwMedici.Name = "dgwMedici";
            this.dgwMedici.RowHeadersVisible = false;
            this.dgwMedici.Size = new System.Drawing.Size(683, 473);
            this.dgwMedici.TabIndex = 0;
            // 
            // tbp2
            // 
            this.tbp2.Controls.Add(this.dgwPatologie);
            this.tbp2.Location = new System.Drawing.Point(4, 22);
            this.tbp2.Name = "tbp2";
            this.tbp2.Padding = new System.Windows.Forms.Padding(3);
            this.tbp2.Size = new System.Drawing.Size(689, 456);
            this.tbp2.TabIndex = 1;
            this.tbp2.Text = "Patologie";
            this.tbp2.UseVisualStyleBackColor = true;
            // 
            // dgwPatologie
            // 
            this.dgwPatologie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPatologie.Location = new System.Drawing.Point(0, 0);
            this.dgwPatologie.Name = "dgwPatologie";
            this.dgwPatologie.RowHeadersVisible = false;
            this.dgwPatologie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwPatologie.Size = new System.Drawing.Size(683, 478);
            this.dgwPatologie.TabIndex = 0;
            // 
            // tbp3
            // 
            this.tbp3.Controls.Add(this.dgwSpecializzazioni);
            this.tbp3.Location = new System.Drawing.Point(4, 22);
            this.tbp3.Name = "tbp3";
            this.tbp3.Size = new System.Drawing.Size(689, 427);
            this.tbp3.TabIndex = 3;
            this.tbp3.Text = "Specializzaioni";
            this.tbp3.UseVisualStyleBackColor = true;
            // 
            // dgwSpecializzazioni
            // 
            this.dgwSpecializzazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSpecializzazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSpecializzazioni.Location = new System.Drawing.Point(0, 0);
            this.dgwSpecializzazioni.Name = "dgwSpecializzazioni";
            this.dgwSpecializzazioni.RowHeadersVisible = false;
            this.dgwSpecializzazioni.Size = new System.Drawing.Size(689, 427);
            this.dgwSpecializzazioni.TabIndex = 0;
            // 
            // tbp4
            // 
            this.tbp4.Controls.Add(this.dgwPazienti);
            this.tbp4.Location = new System.Drawing.Point(4, 22);
            this.tbp4.Name = "tbp4";
            this.tbp4.Size = new System.Drawing.Size(689, 427);
            this.tbp4.TabIndex = 2;
            this.tbp4.Text = "Pazienti";
            this.tbp4.UseVisualStyleBackColor = true;
            // 
            // dgwPazienti
            // 
            this.dgwPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPazienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPazienti.Location = new System.Drawing.Point(0, 0);
            this.dgwPazienti.Name = "dgwPazienti";
            this.dgwPazienti.RowHeadersVisible = false;
            this.dgwPazienti.Size = new System.Drawing.Size(689, 427);
            this.dgwPazienti.TabIndex = 0;
            // 
            // tbp5
            // 
            this.tbp5.Controls.Add(this.tableLayoutPanel1);
            this.tbp5.Location = new System.Drawing.Point(4, 22);
            this.tbp5.Name = "tbp5";
            this.tbp5.Size = new System.Drawing.Size(689, 484);
            this.tbp5.TabIndex = 4;
            this.tbp5.Text = "Appuntamenti";
            this.tbp5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 484);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgwAppuntamenti, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(37, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(614, 405);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.ckbPaziente);
            this.panel2.Controls.Add(this.ckbMedico);
            this.panel2.Controls.Add(this.ckbData);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbPaziente);
            this.panel2.Controls.Add(this.cmbMedico);
            this.panel2.Controls.Add(this.cmbData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 196);
            this.panel2.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(189, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 42);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(75, 119);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(108, 42);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Trova";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ckbPaziente
            // 
            this.ckbPaziente.AutoSize = true;
            this.ckbPaziente.Location = new System.Drawing.Point(281, 94);
            this.ckbPaziente.Name = "ckbPaziente";
            this.ckbPaziente.Size = new System.Drawing.Size(15, 14);
            this.ckbPaziente.TabIndex = 8;
            this.ckbPaziente.UseVisualStyleBackColor = true;
            this.ckbPaziente.CheckedChanged += new System.EventHandler(this.ckbPaziente_CheckedChanged);
            // 
            // ckbMedico
            // 
            this.ckbMedico.AutoSize = true;
            this.ckbMedico.Location = new System.Drawing.Point(281, 67);
            this.ckbMedico.Name = "ckbMedico";
            this.ckbMedico.Size = new System.Drawing.Size(15, 14);
            this.ckbMedico.TabIndex = 7;
            this.ckbMedico.UseVisualStyleBackColor = true;
            this.ckbMedico.CheckedChanged += new System.EventHandler(this.ckbMedico_CheckedChanged);
            // 
            // ckbData
            // 
            this.ckbData.AutoSize = true;
            this.ckbData.Location = new System.Drawing.Point(281, 44);
            this.ckbData.Name = "ckbData";
            this.ckbData.Size = new System.Drawing.Size(15, 14);
            this.ckbData.TabIndex = 6;
            this.ckbData.UseVisualStyleBackColor = true;
            this.ckbData.CheckedChanged += new System.EventHandler(this.ckbpData_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paziente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // cmbPaziente
            // 
            this.cmbPaziente.Enabled = false;
            this.cmbPaziente.FormattingEnabled = true;
            this.cmbPaziente.Location = new System.Drawing.Point(75, 92);
            this.cmbPaziente.Name = "cmbPaziente";
            this.cmbPaziente.Size = new System.Drawing.Size(200, 21);
            this.cmbPaziente.TabIndex = 2;
            // 
            // cmbMedico
            // 
            this.cmbMedico.Enabled = false;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(75, 65);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(200, 21);
            this.cmbMedico.TabIndex = 1;
            // 
            // cmbData
            // 
            this.cmbData.Enabled = false;
            this.cmbData.Location = new System.Drawing.Point(75, 39);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(200, 20);
            this.cmbData.TabIndex = 0;
            // 
            // dgwAppuntamenti
            // 
            this.dgwAppuntamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAppuntamenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwAppuntamenti.Location = new System.Drawing.Point(3, 205);
            this.dgwAppuntamenti.Name = "dgwAppuntamenti";
            this.dgwAppuntamenti.Size = new System.Drawing.Size(608, 197);
            this.dgwAppuntamenti.TabIndex = 1;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm";
            this.Text = "Appuntamenti";
            this.Load += new System.EventHandler(this.frm_Load);
            this.panel1.ResumeLayout(false);
            this.tbc.ResumeLayout(false);
            this.tbp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedici)).EndInit();
            this.tbp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatologie)).EndInit();
            this.tbp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSpecializzazioni)).EndInit();
            this.tbp4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPazienti)).EndInit();
            this.tbp5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppuntamenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbp1;
        private System.Windows.Forms.TabPage tbp3;
        private System.Windows.Forms.TabPage tbp4;
        private System.Windows.Forms.TabPage tbp5;
        private System.Windows.Forms.DataGridView dgwMedici;
        private System.Windows.Forms.DataGridView dgwSpecializzazioni;
        private System.Windows.Forms.DataGridView dgwPazienti;
        private System.Windows.Forms.Button btnAppuntamenti;
        private System.Windows.Forms.Button btnPazienti;
        private System.Windows.Forms.Button btnSpecializzazioni;
        private System.Windows.Forms.Button btnPatologie;
        private System.Windows.Forms.Button btnMedici;
        private System.Windows.Forms.TabPage tbp2;
        private System.Windows.Forms.DataGridView dgwPatologie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwAppuntamenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPaziente;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.DateTimePicker cmbData;
        private System.Windows.Forms.CheckBox ckbPaziente;
        private System.Windows.Forms.CheckBox ckbMedico;
        private System.Windows.Forms.CheckBox ckbData;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
    }
}

