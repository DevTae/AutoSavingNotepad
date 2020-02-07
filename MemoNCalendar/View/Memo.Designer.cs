namespace MemoNCalendar.View
{
    partial class Memo
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memo));
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pinStatusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.opacityStatusLabel = new System.Windows.Forms.Label();
            this.trashCan2 = new System.Windows.Forms.PictureBox();
            this.trashCan1 = new System.Windows.Forms.PictureBox();
            this.ahdelronBlog2 = new System.Windows.Forms.PictureBox();
            this.ahdelronBlog1 = new System.Windows.Forms.PictureBox();
            this.newNote2 = new System.Windows.Forms.PictureBox();
            this.newNote1 = new System.Windows.Forms.PictureBox();
            this.opacitySet2 = new System.Windows.Forms.PictureBox();
            this.programExit2 = new System.Windows.Forms.PictureBox();
            this.removeNote2 = new System.Windows.Forms.PictureBox();
            this.pinForm2 = new System.Windows.Forms.PictureBox();
            this.saveNote2 = new System.Windows.Forms.PictureBox();
            this.listView2 = new System.Windows.Forms.PictureBox();
            this.opacitySet1 = new System.Windows.Forms.PictureBox();
            this.programExit1 = new System.Windows.Forms.PictureBox();
            this.removeNote1 = new System.Windows.Forms.PictureBox();
            this.pinForm1 = new System.Windows.Forms.PictureBox();
            this.saveNote1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trashCan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashCan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahdelronBlog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahdelronBlog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNote2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programExit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeNote2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinForm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveNote2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programExit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeNote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinForm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveNote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox.Location = new System.Drawing.Point(12, 30);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(320, 330);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseMove);
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Location = new System.Drawing.Point(318, 2);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(21, 22);
            this.menuLabel.TabIndex = 12;
            this.menuLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuLabel_MouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(314, 24);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseUp);
            // 
            // pinStatusLabel
            // 
            this.pinStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.pinStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinStatusLabel.ForeColor = System.Drawing.Color.White;
            this.pinStatusLabel.Location = new System.Drawing.Point(188, 364);
            this.pinStatusLabel.Name = "pinStatusLabel";
            this.pinStatusLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pinStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pinStatusLabel.Size = new System.Drawing.Size(145, 21);
            this.pinStatusLabel.TabIndex = 43;
            this.pinStatusLabel.Text = "최상단 고정 : OFF";
            this.pinStatusLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pinStatusLabel_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // opacityStatusLabel
            // 
            this.opacityStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.opacityStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opacityStatusLabel.ForeColor = System.Drawing.Color.White;
            this.opacityStatusLabel.Location = new System.Drawing.Point(12, 364);
            this.opacityStatusLabel.Name = "opacityStatusLabel";
            this.opacityStatusLabel.Size = new System.Drawing.Size(145, 21);
            this.opacityStatusLabel.TabIndex = 44;
            this.opacityStatusLabel.Text = "현재 투명도 : 100%";
            this.opacityStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opacityStatusLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.opacityStatusLabel_MouseMove);
            // 
            // trashCan2
            // 
            this.trashCan2.Image = global::MemoNCalendar.Properties.Resources.trashCan2;
            this.trashCan2.Location = new System.Drawing.Point(562, 402);
            this.trashCan2.Name = "trashCan2";
            this.trashCan2.Size = new System.Drawing.Size(114, 34);
            this.trashCan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trashCan2.TabIndex = 48;
            this.trashCan2.TabStop = false;
            this.trashCan2.Visible = false;
            this.trashCan2.Click += new System.EventHandler(this.trashCan2_Click);
            this.trashCan2.MouseLeave += new System.EventHandler(this.trashCan2_MouseLeave);
            // 
            // trashCan1
            // 
            this.trashCan1.Image = global::MemoNCalendar.Properties.Resources.trashCan1;
            this.trashCan1.Location = new System.Drawing.Point(562, 362);
            this.trashCan1.Name = "trashCan1";
            this.trashCan1.Size = new System.Drawing.Size(114, 34);
            this.trashCan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trashCan1.TabIndex = 47;
            this.trashCan1.TabStop = false;
            this.trashCan1.Visible = false;
            this.trashCan1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trashCan1_MouseMove);
            // 
            // ahdelronBlog2
            // 
            this.ahdelronBlog2.Image = global::MemoNCalendar.Properties.Resources.ahdelronBlog2;
            this.ahdelronBlog2.Location = new System.Drawing.Point(562, 686);
            this.ahdelronBlog2.Name = "ahdelronBlog2";
            this.ahdelronBlog2.Size = new System.Drawing.Size(114, 34);
            this.ahdelronBlog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ahdelronBlog2.TabIndex = 46;
            this.ahdelronBlog2.TabStop = false;
            this.ahdelronBlog2.Visible = false;
            this.ahdelronBlog2.Click += new System.EventHandler(this.ahdelronBlog2_Click);
            this.ahdelronBlog2.MouseLeave += new System.EventHandler(this.ahdelronBlog2_MouseLeave);
            // 
            // ahdelronBlog1
            // 
            this.ahdelronBlog1.Image = global::MemoNCalendar.Properties.Resources.ahdelronBlog1;
            this.ahdelronBlog1.Location = new System.Drawing.Point(562, 647);
            this.ahdelronBlog1.Name = "ahdelronBlog1";
            this.ahdelronBlog1.Size = new System.Drawing.Size(114, 34);
            this.ahdelronBlog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ahdelronBlog1.TabIndex = 45;
            this.ahdelronBlog1.TabStop = false;
            this.ahdelronBlog1.Visible = false;
            this.ahdelronBlog1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ahdelronBlog1_MouseMove);
            // 
            // newNote2
            // 
            this.newNote2.Image = global::MemoNCalendar.Properties.Resources.newNote2;
            this.newNote2.Location = new System.Drawing.Point(562, 49);
            this.newNote2.Name = "newNote2";
            this.newNote2.Size = new System.Drawing.Size(114, 34);
            this.newNote2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newNote2.TabIndex = 23;
            this.newNote2.TabStop = false;
            this.newNote2.Visible = false;
            this.newNote2.Click += new System.EventHandler(this.newNote2_Click);
            this.newNote2.MouseLeave += new System.EventHandler(this.newNote2_MouseLeave);
            // 
            // newNote1
            // 
            this.newNote1.Image = global::MemoNCalendar.Properties.Resources.newNote1;
            this.newNote1.Location = new System.Drawing.Point(562, 9);
            this.newNote1.Name = "newNote1";
            this.newNote1.Size = new System.Drawing.Size(114, 34);
            this.newNote1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newNote1.TabIndex = 22;
            this.newNote1.TabStop = false;
            this.newNote1.Visible = false;
            this.newNote1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.newNote1_MouseMove);
            // 
            // opacitySet2
            // 
            this.opacitySet2.Image = global::MemoNCalendar.Properties.Resources.opacitySet2;
            this.opacitySet2.Location = new System.Drawing.Point(562, 598);
            this.opacitySet2.Name = "opacitySet2";
            this.opacitySet2.Size = new System.Drawing.Size(114, 34);
            this.opacitySet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opacitySet2.TabIndex = 35;
            this.opacitySet2.TabStop = false;
            this.opacitySet2.Visible = false;
            this.opacitySet2.Click += new System.EventHandler(this.opacitySet2_Click);
            this.opacitySet2.MouseLeave += new System.EventHandler(this.opacitySet2_MouseLeave);
            // 
            // programExit2
            // 
            this.programExit2.Image = global::MemoNCalendar.Properties.Resources.programExit2;
            this.programExit2.Location = new System.Drawing.Point(562, 774);
            this.programExit2.Name = "programExit2";
            this.programExit2.Size = new System.Drawing.Size(114, 34);
            this.programExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.programExit2.TabIndex = 33;
            this.programExit2.TabStop = false;
            this.programExit2.Visible = false;
            this.programExit2.Click += new System.EventHandler(this.programExit2_Click);
            this.programExit2.MouseLeave += new System.EventHandler(this.programExit2_MouseLeave);
            // 
            // removeNote2
            // 
            this.removeNote2.Image = global::MemoNCalendar.Properties.Resources.removeNote2;
            this.removeNote2.Location = new System.Drawing.Point(562, 228);
            this.removeNote2.Name = "removeNote2";
            this.removeNote2.Size = new System.Drawing.Size(114, 34);
            this.removeNote2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeNote2.TabIndex = 31;
            this.removeNote2.TabStop = false;
            this.removeNote2.Visible = false;
            this.removeNote2.Click += new System.EventHandler(this.removeNote2_Click);
            this.removeNote2.MouseLeave += new System.EventHandler(this.removeNote2_MouseLeave);
            // 
            // pinForm2
            // 
            this.pinForm2.Image = global::MemoNCalendar.Properties.Resources.pinForm2;
            this.pinForm2.Location = new System.Drawing.Point(562, 491);
            this.pinForm2.Name = "pinForm2";
            this.pinForm2.Size = new System.Drawing.Size(114, 34);
            this.pinForm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinForm2.TabIndex = 29;
            this.pinForm2.TabStop = false;
            this.pinForm2.Visible = false;
            this.pinForm2.Click += new System.EventHandler(this.pinForm2_Click);
            this.pinForm2.MouseLeave += new System.EventHandler(this.pinForm2_MouseLeave);
            // 
            // saveNote2
            // 
            this.saveNote2.Image = global::MemoNCalendar.Properties.Resources.saveNote2;
            this.saveNote2.Location = new System.Drawing.Point(562, 140);
            this.saveNote2.Name = "saveNote2";
            this.saveNote2.Size = new System.Drawing.Size(114, 34);
            this.saveNote2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveNote2.TabIndex = 27;
            this.saveNote2.TabStop = false;
            this.saveNote2.Visible = false;
            this.saveNote2.Click += new System.EventHandler(this.saveNote2_Click);
            this.saveNote2.MouseLeave += new System.EventHandler(this.saveNote2_MouseLeave);
            // 
            // listView2
            // 
            this.listView2.Image = global::MemoNCalendar.Properties.Resources.listView2;
            this.listView2.Location = new System.Drawing.Point(562, 314);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(114, 34);
            this.listView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.listView2.TabIndex = 25;
            this.listView2.TabStop = false;
            this.listView2.Visible = false;
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            this.listView2.MouseLeave += new System.EventHandler(this.listView2_MouseLeave);
            // 
            // opacitySet1
            // 
            this.opacitySet1.Image = global::MemoNCalendar.Properties.Resources.opacitySet1;
            this.opacitySet1.Location = new System.Drawing.Point(562, 558);
            this.opacitySet1.Name = "opacitySet1";
            this.opacitySet1.Size = new System.Drawing.Size(114, 34);
            this.opacitySet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opacitySet1.TabIndex = 34;
            this.opacitySet1.TabStop = false;
            this.opacitySet1.Visible = false;
            this.opacitySet1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.opacitySet1_MouseMove);
            // 
            // programExit1
            // 
            this.programExit1.Image = global::MemoNCalendar.Properties.Resources.programExit1;
            this.programExit1.Location = new System.Drawing.Point(562, 735);
            this.programExit1.Name = "programExit1";
            this.programExit1.Size = new System.Drawing.Size(114, 34);
            this.programExit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.programExit1.TabIndex = 32;
            this.programExit1.TabStop = false;
            this.programExit1.Visible = false;
            this.programExit1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.programExit1_MouseMove);
            // 
            // removeNote1
            // 
            this.removeNote1.Image = global::MemoNCalendar.Properties.Resources.removeNote1;
            this.removeNote1.Location = new System.Drawing.Point(562, 189);
            this.removeNote1.Name = "removeNote1";
            this.removeNote1.Size = new System.Drawing.Size(114, 34);
            this.removeNote1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeNote1.TabIndex = 30;
            this.removeNote1.TabStop = false;
            this.removeNote1.Visible = false;
            this.removeNote1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.removeNote1_MouseMove);
            // 
            // pinForm1
            // 
            this.pinForm1.Image = global::MemoNCalendar.Properties.Resources.pinForm1;
            this.pinForm1.Location = new System.Drawing.Point(562, 452);
            this.pinForm1.Name = "pinForm1";
            this.pinForm1.Size = new System.Drawing.Size(114, 34);
            this.pinForm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinForm1.TabIndex = 28;
            this.pinForm1.TabStop = false;
            this.pinForm1.Visible = false;
            this.pinForm1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pinForm1_MouseMove);
            // 
            // saveNote1
            // 
            this.saveNote1.Image = global::MemoNCalendar.Properties.Resources.saveNote1;
            this.saveNote1.Location = new System.Drawing.Point(562, 101);
            this.saveNote1.Name = "saveNote1";
            this.saveNote1.Size = new System.Drawing.Size(114, 34);
            this.saveNote1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveNote1.TabIndex = 26;
            this.saveNote1.TabStop = false;
            this.saveNote1.Visible = false;
            this.saveNote1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.saveNote1_MouseMove);
            // 
            // listView1
            // 
            this.listView1.Image = global::MemoNCalendar.Properties.Resources.listView1;
            this.listView1.Location = new System.Drawing.Point(562, 275);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(114, 34);
            this.listView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.listView1.TabIndex = 24;
            this.listView1.TabStop = false;
            this.listView1.Visible = false;
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 858);
            this.ControlBox = false;
            this.Controls.Add(this.trashCan2);
            this.Controls.Add(this.trashCan1);
            this.Controls.Add(this.ahdelronBlog2);
            this.Controls.Add(this.ahdelronBlog1);
            this.Controls.Add(this.opacityStatusLabel);
            this.Controls.Add(this.newNote2);
            this.Controls.Add(this.newNote1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.pinStatusLabel);
            this.Controls.Add(this.opacitySet2);
            this.Controls.Add(this.programExit2);
            this.Controls.Add(this.removeNote2);
            this.Controls.Add(this.pinForm2);
            this.Controls.Add(this.saveNote2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.opacitySet1);
            this.Controls.Add(this.programExit1);
            this.Controls.Add(this.removeNote1);
            this.Controls.Add(this.pinForm1);
            this.Controls.Add(this.saveNote1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Memo";
            this.Text = "Memo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Memo_FormClosing);
            this.Load += new System.EventHandler(this.Memo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Memo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.trashCan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashCan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahdelronBlog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahdelronBlog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNote2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programExit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeNote2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinForm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveNote2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programExit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeNote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinForm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveNote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox newNote1;
        private System.Windows.Forms.Label pinStatusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox newNote2;
        private System.Windows.Forms.PictureBox programExit2;
        private System.Windows.Forms.PictureBox programExit1;
        private System.Windows.Forms.PictureBox opacitySet2;
        private System.Windows.Forms.PictureBox opacitySet1;
        private System.Windows.Forms.PictureBox removeNote2;
        private System.Windows.Forms.PictureBox removeNote1;
        private System.Windows.Forms.PictureBox pinForm2;
        private System.Windows.Forms.PictureBox pinForm1;
        private System.Windows.Forms.PictureBox saveNote2;
        private System.Windows.Forms.PictureBox saveNote1;
        private System.Windows.Forms.PictureBox listView2;
        private System.Windows.Forms.PictureBox listView1;
        private System.Windows.Forms.Label opacityStatusLabel;
        private System.Windows.Forms.PictureBox ahdelronBlog2;
        private System.Windows.Forms.PictureBox ahdelronBlog1;
        private System.Windows.Forms.PictureBox trashCan2;
        private System.Windows.Forms.PictureBox trashCan1;
    }
}

