using MemoNCalendar.Model;
using System;
using System.IO;
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
            this.note = note;
            InitializeComponent();
        }

        private void Memo_Load(object sender, EventArgs e)
        {
            textBox.Text = note.getMemo().ToString();
        }

        // Memo_Close() 함수 : 작성중인 메모 내용을 삭제하겠다는 말과 동일함.
        private void Memo_Close()
        {
            if(Main.windowCount == 1)
            {
                Terminate();
            }

            DialogResult result = MessageBox.Show(null, "모든 메모 탭을 닫겠습니까?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Terminate();
            }
            else if (result == DialogResult.No)
            {
                this.Hide();
                Main.windowCount--;
            }
        }

        // 노트 탭 하나만 종료할 때 쓰이는 함수 (리스트로 감.)
        private void Save_and_Quit() 
        {
            sw = new StreamWriter(@"data\" + note.getFileName());
            sw.Write(Controller.StringConverter.ToFile(textBox.Text, Controller.StringConverter.option_off));
            sw.Close();
            note.setIsActivate(false);
            Main.windowCount--;
            this.Hide();
        }

        private void New_Memo()
        {
            //Memo newform = new Memo();
            //newform.Show();
        }

        private void Terminate()
        {
            Environment.Exit(0);
        }

        private void Memo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Memo_Close();
            e.Cancel = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            sw = new StreamWriter(@"data\" + note.getFileName());
            sw.Write(Controller.StringConverter.ToFile(textBox.Text, Controller.StringConverter.option_on));
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Memo_Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Save_and_Quit();
        }
    }
}
