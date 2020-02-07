namespace MemoNCalendar.View
{
    partial class TrashCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrashCan));
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.previewText = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(350, 154);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "선택한 노트 복구";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // previewText
            // 
            this.previewText.Enabled = false;
            this.previewText.ForeColor = System.Drawing.Color.Gray;
            this.previewText.Location = new System.Drawing.Point(12, 203);
            this.previewText.Multiline = true;
            this.previewText.Name = "previewText";
            this.previewText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewText.Size = new System.Drawing.Size(489, 212);
            this.previewText.TabIndex = 2;
            this.previewText.Text = "<미리보기>";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 179);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 15);
            this.label.TabIndex = 3;
            this.label.Text = "<미리보기>";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "선택한 노트 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "휴지통 비우기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "리스트 갱신";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TrashCan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(513, 427);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.previewText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrashCan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrashCan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrashCan_FormClosing);
            this.Load += new System.EventHandler(this.TrashCan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox previewText;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}