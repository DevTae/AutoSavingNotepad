namespace MemoNCalendar.View
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.previewText = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(368, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 154);
            this.button1.TabIndex = 1;
            this.button1.Text = "선택한 노트 열기";
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
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 427);
            this.Controls.Add(this.label);
            this.Controls.Add(this.previewText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemoList";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.List_FormClosing);
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox previewText;
        private System.Windows.Forms.Label label;
    }
}