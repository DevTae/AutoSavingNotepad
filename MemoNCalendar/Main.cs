using MemoNCalendar.Controller;
using MemoNCalendar.Model;
using MemoNCalendar.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoNCalendar
{
    public partial class Main : Form
    {
        public static string version = "1.00";
        public static int windowCount = 0;
        public static List<Memo> memos;
        List<Note> notes;

        public Main()
        {
            InitializeComponent();
        }

        private void loginFunction(string idText, string pwText)
        {
            MessageBox.Show(null, "성공", "성공!");

            memos = new List<Memo>();
            foreach (Note note in notes)
            {
                Memo memo = new Memo(note);
                memos.Add(memo);
                memo.Show();
                windowCount++;
            }
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            notes = FileIn.LoadAllMemos(startupPath + @"\data");
        }

        private void idText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginFunction(idText.Text, pwText.Text);
            }
        }

        private void pwText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginFunction(idText.Text, pwText.Text);
            }
        }

        private void pwText_Enter(object sender, EventArgs e)
        {
            if (pwText.Text.Equals("randomPW!$")) // 원한다면 bool 자료형을 써서 구현 가능함. // 하드코딩
            {
                pwText.Text = "";
                pwText.ForeColor = Color.Black;
            }
        }

        private void idText_Enter(object sender, EventArgs e)
        {
            if (idText.Text.Equals("ID를 입력해주세요."))
            {
                idText.Text = "";
                idText.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginFunction(idText.Text, pwText.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
