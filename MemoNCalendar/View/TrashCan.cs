using MemoNCalendar.Controller;
using MemoNCalendar.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

/**
 * 
 * Copyright (c) 2020, ahdelron All rights reserved.
 * https://ahdelron.tistory.com/
 * 
 */

namespace MemoNCalendar.View
{
    public partial class TrashCan : Form
    {
        public TrashCan()
        {
            Main.isTrashCan = true;
            InitializeComponent();
        }

        private void TrashCan_Load(object sender, EventArgs e)
        {
            foreach (Note note in Main.notes)
            {
                if (note.getFileStatus() == Note.trash)
                {
                    listBox.Items.Add(note.getFileName());
                }
            }
        }

        private void Activate_Memo()
        {
            foreach(Note note in Main.notes)
            {
                if(listBox.Text == note.getFileName())
                {
                    note.setFileStatus(Note.on);
                    Memo memo = new Memo(note);
                    Main.memos.Add(memo);
                    memo.Show();
                    //listBox.Items.Remove(listBox.SelectedItem);
                    //previewText.Text = "<미리보기>";
                    //previewText.ForeColor = Color.Gray;
                    //Main.isTrashCan = false;
                    //this.Close();
                    Refresh_Listbox();
                    break;
                }
            }
        }

        private void Restore_Memo()
        {
            foreach (Note note in Main.notes)
            {
                if (listBox.Text == note.getFileName())
                {
                    note.setFileStatus(Note.off);
                    Refresh_Listbox();
                    break;
                }
            }
        }

        private void Remove_Memo()
        {
            foreach (Note note in Main.notes)
            {
                if (listBox.Text == note.getFileName())
                {
                    Main.notes.Remove(note);
                    if(FileOut.removeMemoFile(note.getFileName())) {
                        MessageBox.Show(new Form() { TopMost = true }, "선택한 메모 파일을 삭제했습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show(new Form() { TopMost = true }, "삭제 과정에서 오류가 발생했습니다.", "예외 처리", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    listBox.Items.Remove(listBox.SelectedItem);
                    //Main.isTrashCan = false;
                    //this.Close();
                    Refresh_Listbox();
                    break;
                }
            }
        }

        private void Empty_TrashCan()
        {
            try
            {
                List<Note> trashes = new List<Note>();
                foreach (Note note in Main.notes)
                {
                    if(note.getFileStatus() == Note.trash)
                    {
                        trashes.Add(note);
                    }
                }
                foreach(Note trash in trashes)
                {
                    Main.notes.Remove(trash);
                    if (!FileOut.removeMemoFile(trash.getFileName()))
                    {
                        throw new FileLoadException();
                    }
                }
                trashes.Clear();
                MessageBox.Show(new Form() { TopMost = true }, "휴지통을 비웠습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(FileLoadException e)
            {
                MessageBox.Show(new Form() { TopMost = true }, "휴지통을 비우는 과정에서 오류가 발생했습니다.", "예외 처리", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Main.isTrashCan = false;
            this.Close();
        }

        private void Refresh_Listbox()
        {
            listBox.Items.Clear();
            previewText.Text = "<미리보기>";
            previewText.ForeColor = Color.Gray;
            foreach (Note note in Main.notes)
            {
                if (note.getFileStatus() == Note.trash)
                {
                    listBox.Items.Add(note.getFileName());
                }
            }
        }

        

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Note note in Main.notes)
            {
                if (listBox.Text == note.getFileName())
                {
                    previewText.Text = note.getMemo().ToString();
                    previewText.ForeColor = Color.Black;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activate_Memo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove_Memo();
        }

        private void TrashCan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.isTrashCan = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empty_TrashCan();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Restore_Memo();
        }

        ToolTip toolTip = new ToolTip();

        private void button1_MouseHover(object sender, EventArgs e) // 열기
        {
            toolTip.Show("열기 버튼을 누르면 선택한 메모장이 활성화됩니다.", button1);
        }

        private void button5_MouseHover(object sender, EventArgs e) // 복구
        {
            toolTip.Show("복구 버튼을 누르면 선택한 메모장이 리스트뷰로 옮겨집니다.", button5);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("이 버튼을 누르면 선택한 메모장이 영구삭제됩니다.", button2);
        }

        private void TrashCan_Activated(object sender, EventArgs e)
        {
            Refresh_Listbox();
        }
    }
}
