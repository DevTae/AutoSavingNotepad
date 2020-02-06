using MemoNCalendar.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

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
                if (!note.getIsActivate())
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
                    note.setIsActivate(true);
                    Memo memo = new Memo(note);
                    Main.memos.Add(memo);
                    memo.Show();
                    listBox.Items.Remove(listBox.SelectedItem);
                    previewText.Text = "<미리보기>";
                    previewText.ForeColor = Color.Gray;
                    Main.isListView = false;
                    this.Close();
                    break;
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

        private void List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.isListView = false;
        }
    }
}
