namespace WinFormsApp2
{
    partial class Form1
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
            this.QLSV = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaNhanVien = new System.Windows.Forms.Label();
            this.TenLop = new System.Windows.Forms.Label();
            this.MaLop = new System.Windows.Forms.Label();
            this.QLSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QLSV
            // 
            this.QLSV.Controls.Add(this.dataGridView1);
            this.QLSV.Location = new System.Drawing.Point(12, 12);
            this.QLSV.Name = "QLSV";
            this.QLSV.Size = new System.Drawing.Size(873, 312);
            this.QLSV.TabIndex = 0;
            this.QLSV.TabStop = false;
            this.QLSV.Text = "QLSV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(829, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sua);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Them);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.MaNhanVien);
            this.groupBox1.Controls.Add(this.TenLop);
            this.groupBox1.Controls.Add(this.MaLop);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(561, 119);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(91, 26);
            this.Sua.TabIndex = 9;
            this.Sua.Text = "Sua";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, -296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(561, 69);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(91, 26);
            this.Them.TabIndex = 6;
            this.Them.Text = "Them";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(290, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 23);
            this.textBox1.TabIndex = 3;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AutoSize = true;
            this.MaNhanVien.Location = new System.Drawing.Point(24, 139);
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Size = new System.Drawing.Size(76, 15);
            this.MaNhanVien.TabIndex = 2;
            this.MaNhanVien.Text = "MaNhanVien";
            // 
            // TenLop
            // 
            this.TenLop.AutoSize = true;
            this.TenLop.Location = new System.Drawing.Point(26, 95);
            this.TenLop.Name = "TenLop";
            this.TenLop.Size = new System.Drawing.Size(45, 15);
            this.TenLop.TabIndex = 1;
            this.TenLop.Text = "TenLop";
            // 
            // MaLop
            // 
            this.MaLop.AutoSize = true;
            this.MaLop.Location = new System.Drawing.Point(26, 47);
            this.MaLop.Name = "MaLop";
            this.MaLop.Size = new System.Drawing.Size(47, 15);
            this.MaLop.TabIndex = 0;
            this.MaLop.Text = "MaLop ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QLSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QLSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox QLSV;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label MaNhanVien;
        private Label TenLop;
        private Label MaLop;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button Xoa;
        private Button Them;
        private Button Sua;
        private Button button3;
    }
}