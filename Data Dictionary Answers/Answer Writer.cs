using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Data_Dictionary_Answers
{
    public partial class Form1 : Form
    {
        public static int answerCount = -1 ;
        public static string answersInput;
        static string formattedAnswerTemplateMiddle = "| {0}, {1} ";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAnswer_Click(object sender, EventArgs e)
        {
           
            answerCount++;
            answersInput = AnswerInput.Text;
            string formattedAnswer = string.Format(formattedAnswerTemplateMiddle, answerCount, answersInput);
            if (answerCount == 0)
            {
                formattedAnswer = formattedAnswer.Substring(2);
            }
            FormattedAnswers.Text += formattedAnswer;
            AnswerInput.Clear();

  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s1 = FormattedAnswers.Text;
                Clipboard.SetText(s1);
            }
            catch (Exception)
            {
                MessageBox.Show("Formatted Answers List Can't Be Blank");

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormattedAnswers.Items.Clear();
            FormattedAnswers.Clear();
            answerCount = -1;
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
