namespace Timer_Kesme
{
    partial class Form1
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
            this.comboBox_PreScalar = new System.Windows.Forms.ComboBox();
            this.comboBox_Timer = new System.Windows.Forms.ComboBox();
            this.textBox_wanted_time = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interrupts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_sadece_tamsayi = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_PreScalar
            // 
            this.comboBox_PreScalar.FormattingEnabled = true;
            this.comboBox_PreScalar.Location = new System.Drawing.Point(136, 24);
            this.comboBox_PreScalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_PreScalar.Name = "comboBox_PreScalar";
            this.comboBox_PreScalar.Size = new System.Drawing.Size(79, 21);
            this.comboBox_PreScalar.TabIndex = 0;
            this.comboBox_PreScalar.Text = "Prescalar";
            this.comboBox_PreScalar.SelectedIndexChanged += new System.EventHandler(this.comboBox_PreScalar_SelectedIndexChanged);
            // 
            // comboBox_Timer
            // 
            this.comboBox_Timer.FormattingEnabled = true;
            this.comboBox_Timer.Items.AddRange(new object[] {
            "Timer0",
            "Timer1",
            "Timer2"});
            this.comboBox_Timer.Location = new System.Drawing.Point(136, 2);
            this.comboBox_Timer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Timer.Name = "comboBox_Timer";
            this.comboBox_Timer.Size = new System.Drawing.Size(76, 21);
            this.comboBox_Timer.TabIndex = 1;
            this.comboBox_Timer.Text = "Timer0";
            this.comboBox_Timer.SelectedIndexChanged += new System.EventHandler(this.comboBox_Timer_SelectedIndexChanged);
            // 
            // textBox_wanted_time
            // 
            this.textBox_wanted_time.Location = new System.Drawing.Point(136, 48);
            this.textBox_wanted_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_wanted_time.Name = "textBox_wanted_time";
            this.textBox_wanted_time.Size = new System.Drawing.Size(96, 20);
            this.textBox_wanted_time.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baslangic,
            this.Interrupts});
            this.dataGridView1.Location = new System.Drawing.Point(4, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(262, 459);
            this.dataGridView1.TabIndex = 3;
            // 
            // baslangic
            // 
            this.baslangic.HeaderText = "Timer Set";
            this.baslangic.Name = "baslangic";
            this.baslangic.ReadOnly = true;
            // 
            // Interrupts
            // 
            this.Interrupts.HeaderText = "Interrupts";
            this.Interrupts.Name = "Interrupts";
            this.Interrupts.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kaç Saniye:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bölme Değeri  Seç:";
            // 
            // checkBox_sadece_tamsayi
            // 
            this.checkBox_sadece_tamsayi.AutoSize = true;
            this.checkBox_sadece_tamsayi.Checked = true;
            this.checkBox_sadece_tamsayi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sadece_tamsayi.Location = new System.Drawing.Point(42, 74);
            this.checkBox_sadece_tamsayi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_sadece_tamsayi.Name = "checkBox_sadece_tamsayi";
            this.checkBox_sadece_tamsayi.Size = new System.Drawing.Size(190, 17);
            this.checkBox_sadece_tamsayi.TabIndex = 8;
            this.checkBox_sadece_tamsayi.Text = "Sadece Tamsayılı İnterrupts Göster";
            this.checkBox_sadece_tamsayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_sadece_tamsayi.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 592);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zaman Hesaplama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBox_sadece_tamsayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_wanted_time);
            this.Controls.Add(this.comboBox_Timer);
            this.Controls.Add(this.comboBox_PreScalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Kesme Hesaplama Aracı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_PreScalar;
        private System.Windows.Forms.ComboBox comboBox_Timer;
        private System.Windows.Forms.TextBox textBox_wanted_time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interrupts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_sadece_tamsayi;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
    }
}

