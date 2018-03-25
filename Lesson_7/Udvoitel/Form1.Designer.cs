namespace Udvoitel
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
            this.btnCmd1 = new System.Windows.Forms.Button();
            this.btnCmd2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lbl_N = new System.Windows.Forms.Label();
            this.lbl_N_Txt = new System.Windows.Forms.Label();
            this.lblResultTxt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Play_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Back_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Target_text_lbl = new System.Windows.Forms.Label();
            this.Target_lbl = new System.Windows.Forms.Label();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCmd1
            // 
            this.btnCmd1.Location = new System.Drawing.Point(12, 156);
            this.btnCmd1.Name = "btnCmd1";
            this.btnCmd1.Size = new System.Drawing.Size(126, 40);
            this.btnCmd1.TabIndex = 0;
            this.btnCmd1.Text = "+1";
            this.btnCmd1.UseVisualStyleBackColor = true;
            this.btnCmd1.Click += new System.EventHandler(this.btnCmd1_Click);
            // 
            // btnCmd2
            // 
            this.btnCmd2.Location = new System.Drawing.Point(144, 156);
            this.btnCmd2.Name = "btnCmd2";
            this.btnCmd2.Size = new System.Drawing.Size(126, 40);
            this.btnCmd2.TabIndex = 1;
            this.btnCmd2.Text = "x2";
            this.btnCmd2.UseVisualStyleBackColor = true;
            this.btnCmd2.Click += new System.EventHandler(this.btnCmd2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 202);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(258, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(58, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // lbl_N
            // 
            this.lbl_N.AutoSize = true;
            this.lbl_N.Location = new System.Drawing.Point(249, 36);
            this.lbl_N.Name = "lbl_N";
            this.lbl_N.Size = new System.Drawing.Size(13, 13);
            this.lbl_N.TabIndex = 4;
            this.lbl_N.Text = "0";
            // 
            // lbl_N_Txt
            // 
            this.lbl_N_Txt.AutoSize = true;
            this.lbl_N_Txt.Location = new System.Drawing.Point(221, 36);
            this.lbl_N_Txt.Name = "lbl_N_Txt";
            this.lbl_N_Txt.Size = new System.Drawing.Size(24, 13);
            this.lbl_N_Txt.TabIndex = 5;
            this.lbl_N_Txt.Text = "N =";
            // 
            // lblResultTxt
            // 
            this.lblResultTxt.AutoSize = true;
            this.lblResultTxt.Location = new System.Drawing.Point(12, 36);
            this.lblResultTxt.Name = "lblResultTxt";
            this.lblResultTxt.Size = new System.Drawing.Size(40, 13);
            this.lblResultTxt.TabIndex = 6;
            this.lblResultTxt.Text = "Result:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Play_ToolStripMenuItem,
            this.Back_ToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Play_ToolStripMenuItem
            // 
            this.Play_ToolStripMenuItem.Name = "Play_ToolStripMenuItem";
            this.Play_ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.Play_ToolStripMenuItem.Text = "Играть";
            this.Play_ToolStripMenuItem.Click += new System.EventHandler(this.Play_ToolStripMenuItem_Click);
            // 
            // Back_ToolStripMenuItem
            // 
            this.Back_ToolStripMenuItem.Name = "Back_ToolStripMenuItem";
            this.Back_ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.Back_ToolStripMenuItem.Text = "Отменить";
            this.Back_ToolStripMenuItem.Click += new System.EventHandler(this.Back_ToolStripMenuItem_Click);
            // 
            // Target_text_lbl
            // 
            this.Target_text_lbl.AutoSize = true;
            this.Target_text_lbl.Location = new System.Drawing.Point(12, 63);
            this.Target_text_lbl.Name = "Target_text_lbl";
            this.Target_text_lbl.Size = new System.Drawing.Size(36, 13);
            this.Target_text_lbl.TabIndex = 8;
            this.Target_text_lbl.Text = "Цель:";
            // 
            // Target_lbl
            // 
            this.Target_lbl.AutoSize = true;
            this.Target_lbl.Location = new System.Drawing.Point(58, 63);
            this.Target_lbl.Name = "Target_lbl";
            this.Target_lbl.Size = new System.Drawing.Size(13, 13);
            this.Target_lbl.TabIndex = 9;
            this.Target_lbl.Text = "0";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Target_lbl);
            this.Controls.Add(this.Target_text_lbl);
            this.Controls.Add(this.lblResultTxt);
            this.Controls.Add(this.lbl_N_Txt);
            this.Controls.Add(this.lbl_N);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCmd2);
            this.Controls.Add(this.btnCmd1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCmd1;
        private System.Windows.Forms.Button btnCmd2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lbl_N;
        private System.Windows.Forms.Label lbl_N_Txt;
        private System.Windows.Forms.Label lblResultTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Play_ToolStripMenuItem;
        private System.Windows.Forms.Label Target_text_lbl;
        private System.Windows.Forms.Label Target_lbl;
        private System.Windows.Forms.ToolStripMenuItem Back_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

