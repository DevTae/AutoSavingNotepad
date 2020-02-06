namespace MemoNCalendar
{
    partial class Main
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
            this.idText = new System.Windows.Forms.TextBox();
            this.pwText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idText
            // 
            this.idText.ForeColor = System.Drawing.Color.Gray;
            this.idText.Location = new System.Drawing.Point(86, 64);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(178, 25);
            this.idText.TabIndex = 1;
            this.idText.Text = "ID를 입력해주세요.";
            this.idText.Enter += new System.EventHandler(this.idText_Enter);
            this.idText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idText_KeyDown);
            // 
            // pwText
            // 
            this.pwText.ForeColor = System.Drawing.Color.Gray;
            this.pwText.Location = new System.Drawing.Point(86, 107);
            this.pwText.Name = "pwText";
            this.pwText.PasswordChar = '●';
            this.pwText.Size = new System.Drawing.Size(178, 25);
            this.pwText.TabIndex = 2;
            this.pwText.Text = "randomPW!$";
            this.pwText.Enter += new System.EventHandler(this.pwText_Enter);
            this.pwText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwText_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "회원가입";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 194);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwText);
            this.Controls.Add(this.idText);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox pwText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}