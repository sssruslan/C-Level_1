namespace BelieveOrNotBelieve
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_Question = new System.Windows.Forms.RichTextBox();
            this.lbl_True = new System.Windows.Forms.Label();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lbl_QValue = new System.Windows.Forms.Label();
            this.lbl_QMax = new System.Windows.Forms.Label();
            this.lbl_False = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rtb_Question
            // 
            this.rtb_Question.Location = new System.Drawing.Point(13, 46);
            this.rtb_Question.Name = "rtb_Question";
            this.rtb_Question.Size = new System.Drawing.Size(492, 225);
            this.rtb_Question.TabIndex = 1;
            this.rtb_Question.Text = "";
            // 
            // lbl_True
            // 
            this.lbl_True.AutoSize = true;
            this.lbl_True.Location = new System.Drawing.Point(65, 297);
            this.lbl_True.Name = "lbl_True";
            this.lbl_True.Size = new System.Drawing.Size(13, 13);
            this.lbl_True.TabIndex = 3;
            this.lbl_True.Text = "0";
            // 
            // btn_Yes
            // 
            this.btn_Yes.Location = new System.Drawing.Point(259, 289);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(100, 28);
            this.btn_Yes.TabIndex = 4;
            this.btn_Yes.Text = "Верю";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(389, 289);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 28);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "Не верю";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lbl_QValue
            // 
            this.lbl_QValue.AutoSize = true;
            this.lbl_QValue.Location = new System.Drawing.Point(220, 30);
            this.lbl_QValue.Name = "lbl_QValue";
            this.lbl_QValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_QValue.TabIndex = 6;
            this.lbl_QValue.Text = "1";
            // 
            // lbl_QMax
            // 
            this.lbl_QMax.AutoSize = true;
            this.lbl_QMax.Location = new System.Drawing.Point(260, 30);
            this.lbl_QMax.Name = "lbl_QMax";
            this.lbl_QMax.Size = new System.Drawing.Size(13, 13);
            this.lbl_QMax.TabIndex = 7;
            this.lbl_QMax.Text = "1";
            // 
            // lbl_False
            // 
            this.lbl_False.AutoSize = true;
            this.lbl_False.Location = new System.Drawing.Point(179, 297);
            this.lbl_False.Name = "lbl_False";
            this.lbl_False.Size = new System.Drawing.Size(13, 13);
            this.lbl_False.TabIndex = 8;
            this.lbl_False.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вопрос";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "из";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Верно";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ошибочно";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 333);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_False);
            this.Controls.Add(this.lbl_QMax);
            this.Controls.Add(this.lbl_QValue);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.lbl_True);
            this.Controls.Add(this.rtb_Question);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Игра";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtb_Question;
        private System.Windows.Forms.Label lbl_True;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lbl_QValue;
        private System.Windows.Forms.Label lbl_QMax;
        private System.Windows.Forms.Label lbl_False;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}