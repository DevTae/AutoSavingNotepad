using MemoNCalendar.Controller;
using MemoNCalendar.Model;
using System;
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
            nowTime.Text = "생성 날짜 : " + note.getFileName();
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
                pinStatus.Text = "고정풀림";
                this.TopMost = false;
            } else
            {
                pinStatus.Text = "고정됨";
                this.TopMost = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            New_Memo();
        }

        private void pinStatus_Click(object sender, EventArgs e)
        {
            Pin_OrNot();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Terminate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Go_Trashcan();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Save_and_Quit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowListForm();
        }
    }
}
