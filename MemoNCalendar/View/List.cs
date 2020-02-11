using MemoNCalendar.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/**
 * 
 * Copyright (c) 2020, ahdelron All rights reserved.
 * https://ahdelron.tistory.com/
 * 
 */

namespace MemoNCalendar.View
{
    public partial class List : Form
    {
        public List()
        {
            Main.isListView = true;
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            foreach (Note note in Main.notes)
            {
                if (note.getFileStatus() == Note.off)
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
                    listBox.Items.Remove(listBox.SelectedItem);
                    Refresh_Listbox();
                    break;
                }
            }
        }

        private void Go_TrashCan()
        {
            DialogResult result = MessageBox.Show(new Form() { TopMost = true }, "정말로 이 노트를 휴지통으로 옮기시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Note note in Main.notes)
                {
                    if (listBox.Text == note.getFileName())
                    {
                        note.setFileStatus(Note.trash);
                        listBox.Items.Remove(listBox.SelectedItem);
                        Refresh_Listbox();
                        break;
                    }
                }
            }
        }

        private void Refresh_Listbox()
        {
            searchTextBox.Text = "";
            previewText.Text = "<미리보기>";
            noteLenLabel.Text = "해당 노트 : (선택 안됨)";
            previewText.ForeColor = Color.Gray;
            listBox.Items.Clear();
            foreach (Note note in Main.notes)
            {
                if (note.getFileStatus() == Note.off)
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
                    noteLenLabel.Text = "해당 노트 : " + note.getMemo().ToString().Length + " 글자";
                    previewText.Text = note.getMemo().ToString();
                    previewText.ForeColor = Color.Black;
                    break;
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            previewText.Text = "<미리보기>";
            previewText.ForeColor = Color.Gray;
            noteLenLabel.Text = "해당 노트 : (선택 안됨)";
            foreach (Note note in Main.notes)
            {
                if (note.getFileStatus() == Note.off && note.getMemo().ToString().Contains(searchTextBox.Text))
                {
                    listBox.Items.Add(note.getFileName());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activate_Memo();
        }

        private void List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.isListView = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Go_TrashCan();
        }

        private void List_Activated(object sender, EventArgs e)
        {
            Refresh_Listbox();
        }
    }
}
