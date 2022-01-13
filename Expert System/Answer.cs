using System;
using System.Windows.Forms;

namespace Expert_System
{
    public partial class Answer : Form
    {
        public Rule Rule;
        public int pr;
        public Answer(Rule Rule , int pr)
        {
            this.Rule = Rule;
            this.pr = pr;
            InitializeComponent();
            label4.Text = Rule.answer;
            label5.Text = Rule.adress;            
            label6.Text = Rule.pr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
