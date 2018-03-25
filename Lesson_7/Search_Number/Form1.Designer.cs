namespace Search_Number
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Number_a_UpDown = new System.Windows.Forms.NumericUpDown();
            this.Number_b_UpDown = new System.Windows.Forms.NumericUpDown();
            this.Interval_1_lbl = new System.Windows.Forms.Label();
            this.Interval_2_lbl = new System.Windows.Forms.Label();
            this.Answer_Text_lbl = new System.Windows.Forms.Label();
            this.Answer_lbl = new System.Windows.Forms.Label();
            this.N_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Search_Number_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Play_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Over_btn = new System.Windows.Forms.Button();
            this.Win_lbl = new System.Windows.Forms.Button();
            this.Under_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Number_a_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_b_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Number_UpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Number_a_UpDown
            // 
            this.Number_a_UpDown.Location = new System.Drawing.Point(76, 104);
            this.Number_a_UpDown.Name = "Number_a_UpDown";
            this.Number_a_UpDown.Size = new System.Drawing.Size(53, 20);
            this.Number_a_UpDown.TabIndex = 0;
            // 
            // Number_b_UpDown
            // 
            this.Number_b_UpDown.Location = new System.Drawing.Point(166, 104);
            this.Number_b_UpDown.Name = "Number_b_UpDown";
            this.Number_b_UpDown.Size = new System.Drawing.Size(53, 20);
            this.Number_b_UpDown.TabIndex = 1;
            // 
            // Interval_1_lbl
            // 
            this.Interval_1_lbl.AutoSize = true;
            this.Interval_1_lbl.Location = new System.Drawing.Point(54, 107);
            this.Interval_1_lbl.Name = "Interval_1_lbl";
            this.Interval_1_lbl.Size = new System.Drawing.Size(18, 13);
            this.Interval_1_lbl.TabIndex = 2;
            this.Interval_1_lbl.Text = "от";
            // 
            // Interval_2_lbl
            // 
            this.Interval_2_lbl.AutoSize = true;
            this.Interval_2_lbl.Location = new System.Drawing.Point(145, 108);
            this.Interval_2_lbl.Name = "Interval_2_lbl";
            this.Interval_2_lbl.Size = new System.Drawing.Size(19, 13);
            this.Interval_2_lbl.TabIndex = 3;
            this.Interval_2_lbl.Text = "до";
            // 
            // Answer_Text_lbl
            // 
            this.Answer_Text_lbl.AutoSize = true;
            this.Answer_Text_lbl.Location = new System.Drawing.Point(60, 181);
            this.Answer_Text_lbl.Name = "Answer_Text_lbl";
            this.Answer_Text_lbl.Size = new System.Drawing.Size(103, 13);
            this.Answer_Text_lbl.TabIndex = 6;
            this.Answer_Text_lbl.Text = "Ответ компьютера";
            // 
            // Answer_lbl
            // 
            this.Answer_lbl.AutoSize = true;
            this.Answer_lbl.Location = new System.Drawing.Point(177, 181);
            this.Answer_lbl.Name = "Answer_lbl";
            this.Answer_lbl.Size = new System.Drawing.Size(13, 13);
            this.Answer_lbl.TabIndex = 7;
            this.Answer_lbl.Text = "0";
            // 
            // N_lbl
            // 
            this.N_lbl.AutoSize = true;
            this.N_lbl.Location = new System.Drawing.Point(177, 154);
            this.N_lbl.Name = "N_lbl";
            this.N_lbl.Size = new System.Drawing.Size(13, 13);
            this.N_lbl.TabIndex = 8;
            this.N_lbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Количество попыток";
            // 
            // Search_Number_UpDown
            // 
            this.Search_Number_UpDown.Location = new System.Drawing.Point(114, 40);
            this.Search_Number_UpDown.Name = "Search_Number_UpDown";
            this.Search_Number_UpDown.Size = new System.Drawing.Size(53, 20);
            this.Search_Number_UpDown.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ваше число";
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(177, 39);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(75, 23);
            this.Play_btn.TabIndex = 13;
            this.Play_btn.Text = "Играть";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Over_btn
            // 
            this.Over_btn.Location = new System.Drawing.Point(13, 219);
            this.Over_btn.Name = "Over_btn";
            this.Over_btn.Size = new System.Drawing.Size(75, 23);
            this.Over_btn.TabIndex = 15;
            this.Over_btn.Text = "больше";
            this.Over_btn.UseVisualStyleBackColor = true;
            this.Over_btn.Click += new System.EventHandler(this.Over_btn_Click);
            // 
            // Win_lbl
            // 
            this.Win_lbl.Location = new System.Drawing.Point(100, 211);
            this.Win_lbl.Name = "Win_lbl";
            this.Win_lbl.Size = new System.Drawing.Size(83, 39);
            this.Win_lbl.TabIndex = 16;
            this.Win_lbl.Text = "ВЕРНО!";
            this.Win_lbl.UseVisualStyleBackColor = true;
            this.Win_lbl.Click += new System.EventHandler(this.Win_lbl_Click);
            // 
            // Under_btn
            // 
            this.Under_btn.Location = new System.Drawing.Point(195, 219);
            this.Under_btn.Name = "Under_btn";
            this.Under_btn.Size = new System.Drawing.Size(75, 23);
            this.Under_btn.TabIndex = 17;
            this.Under_btn.Text = "меньше";
            this.Under_btn.UseVisualStyleBackColor = true;
            this.Under_btn.Click += new System.EventHandler(this.Under_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Under_btn);
            this.Controls.Add(this.Win_lbl);
            this.Controls.Add(this.Over_btn);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Search_Number_UpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.N_lbl);
            this.Controls.Add(this.Answer_lbl);
            this.Controls.Add(this.Answer_Text_lbl);
            this.Controls.Add(this.Interval_2_lbl);
            this.Controls.Add(this.Interval_1_lbl);
            this.Controls.Add(this.Number_b_UpDown);
            this.Controls.Add(this.Number_a_UpDown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Number_a_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_b_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Number_UpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Number_a_UpDown;
        private System.Windows.Forms.NumericUpDown Number_b_UpDown;
        private System.Windows.Forms.Label Interval_1_lbl;
        private System.Windows.Forms.Label Interval_2_lbl;
        private System.Windows.Forms.Label Answer_Text_lbl;
        private System.Windows.Forms.Label Answer_lbl;
        private System.Windows.Forms.Label N_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Search_Number_UpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button Over_btn;
        private System.Windows.Forms.Button Win_lbl;
        private System.Windows.Forms.Button Under_btn;
    }
}

