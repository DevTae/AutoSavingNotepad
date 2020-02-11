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
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.noteLenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 42);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(350, 124);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 121);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "검색 :";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(59, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(303, 25);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "선택한 노트 삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // noteLenLabel
            // 
            this.noteLenLabel.AutoSize = true;
            this.noteLenLabel.ForeColor = System.Drawing.Color.Navy;
            this.noteLenLabel.Location = new System.Drawing.Point(105, 179);
            this.noteLenLabel.Name = "noteLenLabel";
            this.noteLenLabel.Size = new System.Drawing.Size(164, 15);
            this.noteLenLabel.TabIndex = 8;
            this.noteLenLabel.Text = "해당 노트 : (선택 안됨)";
            // 
            // List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(513, 427);
            this.Controls.Add(this.noteLenLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label2);
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
            this.Text = "리스트뷰";
            this.Activated += new System.EventHandler(this.List_Activated);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label noteLenLabel;
    }
}