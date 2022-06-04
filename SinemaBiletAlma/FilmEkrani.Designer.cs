namespace SinemaBiletAlma
{
    partial class FilmEkrani
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaBiletAlmaDataSet1 = new SinemaBiletAlma.SinemaBiletAlmaDataSet1();
            this.filmlerTableAdapter = new SinemaBiletAlma.SinemaBiletAlmaDataSet1TableAdapters.filmlerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxseans = new System.Windows.Forms.TextBox();
            this.textBoxzivyon = new System.Windows.Forms.TextBox();
            this.textBoxtur = new System.Windows.Forms.TextBox();
            this.textBoxfilmad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaBiletAlmaDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.filmadiDataGridViewTextBoxColumn,
            this.filmturDataGridViewTextBoxColumn,
            this.seansDataGridViewTextBoxColumn,
            this.vizyonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 443);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "filmid";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "filmid";
            this.filmidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmidDataGridViewTextBoxColumn.Width = 50;
            // 
            // filmadiDataGridViewTextBoxColumn
            // 
            this.filmadiDataGridViewTextBoxColumn.DataPropertyName = "filmadi";
            this.filmadiDataGridViewTextBoxColumn.HeaderText = "filmadi";
            this.filmadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmadiDataGridViewTextBoxColumn.Name = "filmadiDataGridViewTextBoxColumn";
            this.filmadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmturDataGridViewTextBoxColumn
            // 
            this.filmturDataGridViewTextBoxColumn.DataPropertyName = "filmtur";
            this.filmturDataGridViewTextBoxColumn.HeaderText = "filmtur";
            this.filmturDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmturDataGridViewTextBoxColumn.Name = "filmturDataGridViewTextBoxColumn";
            this.filmturDataGridViewTextBoxColumn.Width = 110;
            // 
            // seansDataGridViewTextBoxColumn
            // 
            this.seansDataGridViewTextBoxColumn.DataPropertyName = "seans";
            this.seansDataGridViewTextBoxColumn.HeaderText = "seans";
            this.seansDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seansDataGridViewTextBoxColumn.Name = "seansDataGridViewTextBoxColumn";
            this.seansDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizyonDataGridViewTextBoxColumn
            // 
            this.vizyonDataGridViewTextBoxColumn.DataPropertyName = "vizyon";
            this.vizyonDataGridViewTextBoxColumn.HeaderText = "vizyon";
            this.vizyonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vizyonDataGridViewTextBoxColumn.Name = "vizyonDataGridViewTextBoxColumn";
            this.vizyonDataGridViewTextBoxColumn.Width = 75;
            // 
            // filmlerBindingSource
            // 
            this.filmlerBindingSource.DataMember = "filmler";
            this.filmlerBindingSource.DataSource = this.sinemaBiletAlmaDataSet1;
            // 
            // sinemaBiletAlmaDataSet1
            // 
            this.sinemaBiletAlmaDataSet1.DataSetName = "SinemaBiletAlmaDataSet1";
            this.sinemaBiletAlmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmlerTableAdapter
            // 
            this.filmlerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "CINEMAXIMUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aşağıdan film seçimi yapınız";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 632);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxseans);
            this.groupBox2.Controls.Add(this.textBoxzivyon);
            this.groupBox2.Controls.Add(this.textBoxtur);
            this.groupBox2.Controls.Add(this.textBoxfilmad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(699, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 632);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(216, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 66);
            this.button2.TabIndex = 13;
            this.button2.Text = "Fragman İzle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(11, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Bilet Al ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxseans
            // 
            this.textBoxseans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxseans.Location = new System.Drawing.Point(163, 336);
            this.textBoxseans.Name = "textBoxseans";
            this.textBoxseans.Size = new System.Drawing.Size(202, 32);
            this.textBoxseans.TabIndex = 11;
            // 
            // textBoxzivyon
            // 
            this.textBoxzivyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxzivyon.Location = new System.Drawing.Point(163, 276);
            this.textBoxzivyon.Name = "textBoxzivyon";
            this.textBoxzivyon.Size = new System.Drawing.Size(202, 32);
            this.textBoxzivyon.TabIndex = 10;
            // 
            // textBoxtur
            // 
            this.textBoxtur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxtur.Location = new System.Drawing.Point(163, 210);
            this.textBoxtur.Name = "textBoxtur";
            this.textBoxtur.Size = new System.Drawing.Size(202, 32);
            this.textBoxtur.TabIndex = 9;
            // 
            // textBoxfilmad
            // 
            this.textBoxfilmad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxfilmad.Location = new System.Drawing.Point(163, 147);
            this.textBoxfilmad.Name = "textBoxfilmad";
            this.textBoxfilmad.Size = new System.Drawing.Size(202, 32);
            this.textBoxfilmad.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seansı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vizyon Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filmin türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fim Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEÇİLEN FİLM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FilmEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1102, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilmEkrani";
            this.Text = "FilmEkrani";
            this.Load += new System.EventHandler(this.FilmEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaBiletAlmaDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaBiletAlmaDataSet1 sinemaBiletAlmaDataSet1;
        private System.Windows.Forms.BindingSource filmlerBindingSource;
        private SinemaBiletAlmaDataSet1TableAdapters.filmlerTableAdapter filmlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxseans;
        private System.Windows.Forms.TextBox textBoxzivyon;
        private System.Windows.Forms.TextBox textBoxtur;
        private System.Windows.Forms.TextBox textBoxfilmad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}