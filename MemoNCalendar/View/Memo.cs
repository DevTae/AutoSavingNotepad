﻿using MemoNCalendar.Controller;
using MemoNCalendar.Model;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/**
 * 수정 및 재배포 가능합니다. 주석 지우지 말아주세요.
 * @author ahdelron
 */


namespace MemoNCalendar.View
{
    public partial class Memo : Form
    {
        Note note;
        StreamWriter sw;

        public Memo(Note note)
        {
            Main.windowCount++;
            this.note = note;
            InitializeComponent();
        }

        private void Memo_Load(object sender, EventArgs e)
        {
            textBox.Text = note.getMemo().ToString();

            titleLabel.Parent = pictureBox1;
            menuLabel.Parent = pictureBox1;
            pinStatusLabel.Parent = pictureBox1;
            opacityStatusLabel.Parent = pictureBox1;

            this.Width = 342;
            this.Height = 406;

            int i = 0;
            int pivotLeft = 228;
            int pivotTop = 24;

            newNote1.Left = pivotLeft;
            newNote1.Top = pivotTop + 34 * i;
            newNote2.Left = pivotLeft;
            newNote2.Top = pivotTop + 34 * i++;

            saveNote1.Left = pivotLeft;
            saveNote1.Top = pivotTop + 34 * i;
            saveNote2.Left = pivotLeft;
            saveNote2.Top = pivotTop + 34 * i++;

            removeNote1.Left = pivotLeft;
            removeNote1.Top = pivotTop + 34 * i;
            removeNote2.Left = pivotLeft;
            removeNote2.Top = pivotTop + 34 * i++;

            listView1.Left = pivotLeft;
            listView1.Top = pivotTop + 34 * i;
            listView2.Left = pivotLeft;
            listView2.Top = pivotTop + 34 * i++;

            pinForm1.Left = pivotLeft;
            pinForm1.Top = pivotTop + 34 * i;
            pinForm2.Left = pivotLeft;
            pinForm2.Top = pivotTop + 34 * i++;

            opacitySet1.Left = pivotLeft;
            opacitySet1.Top = pivotTop + 34 * i;
            opacitySet2.Left = pivotLeft;
            opacitySet2.Top = pivotTop + 34 * i++;

            programExit1.Left = pivotLeft;
            programExit1.Top = pivotTop + 34 * i;
            programExit2.Left = pivotLeft;
            programExit2.Top = pivotTop + 34 * i++;
        }

        /* 구현하고 보니 필요 없는 기능
        // Memo_Close() 함수 : 작성중인 메모 내용을 삭제하겠다는 말과 동일함.
        private void Memo_Close()
        {
            if(Main.windowCount == 1)
            {
                Terminate();
            }

            DialogResult result = MessageBox.Show(null, "모든 메모 탭을 삭제하시겠습니까?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Terminate();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
                Main.windowCount--;
            }
        }
        */

        private void Unload_Me()
        {
            if (Main.windowCount == 1) // handling Exception
            {
                DialogResult result = MessageBox.Show(null, "새 노트를 하나 더 생성하시겠습니까?\n취소 시 종료됩니다.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    New_Memo();
                    Main.windowCount--;
                    this.Hide();
                } else
                {
                    Terminate();
                }
            }
            else
            {
                Main.windowCount--;
                this.Hide();
            }
        }

        // Save_and_Quit() 함수 : 노트 탭 하나만 종료할 때 쓰이는 함수 (리스트로 감.)
        private void Save_and_Quit() 
        {
            sw = new StreamWriter(@"data\" + note.getFileName());
            sw.Write(Controller.StringConverter.ToFile(textBox.Text, Controller.StringConverter.option_off));
            sw.Close();
            note.setIsActivate(false);
            Main.memos.Remove(this);
            Unload_Me();
        }

        private void New_Memo()
        {
            // new Memo 생성
            Note note = null;
            while (true)
            {
                note = FileOut.makeNewMemoFile();
                if (note != null) break;
            }
            Main.notes.Add(note);
            Memo memo = new Memo(note);
            Main.memos.Add(memo);
            memo.Show();
        }

        private void Go_Trashcan()
        {
            DialogResult result = MessageBox.Show(null, "정말로 이 노트를 삭제하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sw = new StreamWriter(@"data\" + note.getFileName());
                // note 옵션에 trash 옵션 없음.
                sw.Write(Controller.StringConverter.ToFile(textBox.Text, Controller.StringConverter.option_trash));
                sw.Close();
                Main.memos.Remove(this);
                Main.notes.Remove(this.note);
                Unload_Me();
            }
        }

        private void Terminate()
        {
            Environment.Exit(0);
        }

        private void ShowListForm()
        {
            if (Main.isListView == false)
            {
                List list = new List();
                list.Show();
            }
            else
            {
                MessageBox.Show(null, "이미 리스트뷰가 켜져 있습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // TopMost 속성 ON / OFF
        // 기본 속성 OFF
        private void Pin_OrNot()
        {
            if(this.TopMost == true)
            {
                pinStatusLabel.Text = "최상단 고정 : OFF";
                pinStatusLabel.ForeColor = Color.White;
                this.TopMost = false;
            } else
            {
                pinStatusLabel.Text = "최상단 고정 : ON";
                pinStatusLabel.ForeColor = Color.Lime;
                this.TopMost = true;
            }
        }

        private void Opacity_Set_Customed()
        {
            if(this.Opacity >= 1)
            {
                this.Opacity = 0.8;
                opacityStatusLabel.Text = "현재 투명도 : 80%";
            } else if(this.Opacity >= 0.8)
            {
                this.Opacity = 0.6;
                opacityStatusLabel.Text = "현재 투명도 : 60%";
            } else if (this.Opacity >= 0.6)
            {
                this.Opacity = 0.4;
                opacityStatusLabel.Text = "현재 투명도 : 40%";
            } else if (this.Opacity >= 0.4)
            {
                this.Opacity = 1;
                opacityStatusLabel.Text = "현재 투명도 : 100%";
            }
        }

        private void Memo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Terminate();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            note.setMemo(new StringBuilder(textBox.Text));
            sw = new StreamWriter(@"data\" + note.getFileName());
            sw.Write(Controller.StringConverter.ToFile(textBox.Text, Controller.StringConverter.option_on));
            sw.Close();
        }

        private void menuLabel_MouseMove(object sender, MouseEventArgs e)
        {
            newNote1.Visible = true;
            listView1.Visible = true;
            saveNote1.Visible = true;
            pinForm1.Visible = true;
            removeNote1.Visible = true;
            opacitySet1.Visible = true;
            programExit1.Visible = true;
        }

        private void Menu_Off()
        {
            newNote1.Visible = false;
            listView1.Visible = false;
            saveNote1.Visible = false;
            pinForm1.Visible = false;
            removeNote1.Visible = false;
            opacitySet1.Visible = false;
            programExit1.Visible = false;

            newNote2.Visible = false;
            listView2.Visible = false;
            saveNote2.Visible = false;
            pinForm2.Visible = false;
            removeNote2.Visible = false;
            opacitySet2.Visible = false;
            programExit2.Visible = false;
        }

        private void Memo_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_Off();
        }

        private void newNote2_Click(object sender, EventArgs e)
        {
            New_Memo();
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            ShowListForm();
        }

        private void saveNote2_Click(object sender, EventArgs e)
        {
            Save_and_Quit();
        }

        private void pinForm2_Click(object sender, EventArgs e)
        {
            Pin_OrNot();
        }

        private void removeNote2_Click(object sender, EventArgs e)
        {
            Go_Trashcan();
        }

        private void opacitySet2_Click(object sender, EventArgs e)
        {
            Opacity_Set_Customed();
        }

        private void programExit2_Click(object sender, EventArgs e)
        {
            Terminate();
        }

        private void newNote1_MouseMove(object sender, MouseEventArgs e)
        {
            newNote1.Visible = false;
            newNote2.Visible = true;
        }

        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            listView1.Visible = false;
            listView2.Visible = true;
        }

        private void saveNote1_MouseMove(object sender, MouseEventArgs e)
        {
            saveNote1.Visible = false;
            saveNote2.Visible = true;
        }

        private void pinForm1_MouseMove(object sender, MouseEventArgs e)
        {
            pinForm1.Visible = false;
            pinForm2.Visible = true;
        }

        private void removeNote1_MouseMove(object sender, MouseEventArgs e)
        {
            removeNote1.Visible = false;
            removeNote2.Visible = true;
        }

        private void opacitySet1_MouseMove(object sender, MouseEventArgs e)
        {
            opacitySet1.Visible = false;
            opacitySet2.Visible = true;
        }

        private void programExit1_MouseMove(object sender, MouseEventArgs e)
        {
            programExit1.Visible = false;
            programExit2.Visible = true;
        }

        private void newNote2_MouseLeave(object sender, EventArgs e)
        {
            newNote1.Visible = true;
            newNote2.Visible = false;
        }

        private void listView2_MouseLeave(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
        }

        private void saveNote2_MouseLeave(object sender, EventArgs e)
        {
            saveNote1.Visible = true;
            saveNote2.Visible = false;
        }

        private void pinForm2_MouseLeave(object sender, EventArgs e)
        {
            pinForm1.Visible = true;
            pinForm2.Visible = false;
        }

        private void removeNote2_MouseLeave(object sender, EventArgs e)
        {
            removeNote1.Visible = true;
            removeNote2.Visible = false;
        }

        private void opacitySet2_MouseLeave(object sender, EventArgs e)
        {
            opacitySet1.Visible = true;
            opacitySet2.Visible = false;
        }

        private void programExit2_MouseLeave(object sender, EventArgs e)
        {
            programExit1.Visible = true;
            programExit2.Visible = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_Off();
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_Off();
        }

        private void opacityStatusLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_Off();
        }

        private void pinStatusLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_Off();
        }

        bool isMove = false;
        Point mousePoint;

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_Off();
            if(isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            mousePoint = new Point(e.X, e.Y);
        }

        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
    }
}
