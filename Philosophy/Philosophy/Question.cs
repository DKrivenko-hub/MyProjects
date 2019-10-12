using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philosophy
{
    public partial class Question : Form
    {
        string Answer;
       
        public RadioButton[] rb;
        public Question(string question, string A, string B, string C, string D, string E, string Answer)
        {
            InitializeComponent();

            MaximumSize = new Size(700, 650);
            MinimumSize = new Size(700, 650);

            rb = new RadioButton[]
            {
                this.A,
                this.B,
                this.C,
                this.D,
                this.E
            };
            for (int i = 0; i < rb.Length; i++)
            {
                rb[i].Checked = false;
            }
            
            CreateQuest( question,  A,  B,  C,  D,  E, Answer);
        }

        void CreateQuest(string question, string A, string B, string C, string D, string E, string Answer)
        {
            label_question.Text = question;
            this.A.Text = A;
            this.B.Text = B;
            this.C.Text = C;
            this.D.Text = D;
            this.E.Text = E;
            this.Answer = Answer;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {
                if (rb[i].Checked == true)
                {
                    if (rb[i].Name == Answer)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        DialogResult = DialogResult.Retry;
                    }
                }
            }
        }
    }
}
