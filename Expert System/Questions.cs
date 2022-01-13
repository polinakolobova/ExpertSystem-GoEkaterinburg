using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Expert_System
{
    public partial class Questions : Form
    {
        List<Rule> ques;
        ComboBox[] comboBox;
        TextBox[] textBox;
        int SIZE;
        public Questions(List<Rule> Ruless, string option)
        {
            ques = Ruless.Where(r => r.option == option).ToList();
            SIZE = ques.Count();
            InitializeComponent();
            Label[] label = new Label[SIZE];
            comboBox = new ComboBox[SIZE];
            textBox = new TextBox[SIZE];
            int i = 0;
            this.Size = new Size(600, 100 + 30 * SIZE);
            foreach (Rule Rule in ques.ToList())
            {
                label[i] = new Label();
                label[i].AutoSize = true;
                label[i].Location = new Point(10, 30 + 30 * i);
                label[i].Name = "label" + i;
                label[i].Size = new Size(450, 20);
                label[i].Text = Rule.question + " ?";
                Controls.Add(label[i]);

                comboBox[i] = new ComboBox();
                comboBox[i].FormattingEnabled = true;
                comboBox[i].DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox[i].Items.AddRange(new object[] { "Да", "Нет" });
                comboBox[i].Location = new Point(460, 30 + 30 * i);
                comboBox[i].Name = "comboBox" + i;
                comboBox[i].Size = new Size(50, 20);
                Controls.Add(comboBox[i]);

                textBox[i] = new TextBox();
                textBox[i].Location = new Point(520, 30 + 30 * i);
                textBox[i].Name = "textBox" + i;
                textBox[i].Size = new Size(50, 20);
                Controls.Add(textBox[i]);

                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<int>> DIC = new Dictionary<string, List<int>>();
            List<string> ss = ques.Select(r => r.answer).Distinct().ToList();
            foreach (string s in ss)
            {
                List<Rule> lst = ques.FindAll(a => a.answer == s);
                List<int> ind = new List<int>();
                foreach (Rule r in lst)
                {
                    ind.Add(ques.FindIndex(q => q.question == r.question));
                }
                DIC.Add(s, ind);
            }
            int[] PR = new int[DIC.Count];
            int j = 0;
            int userMoney=0;
            foreach (string key in DIC.Keys)
            {
                int[] _pr = new int[DIC[key].Count];
                for (int i = 0; i < DIC[key].Count; i++)
                {
                    if (comboBox[DIC[key][i]].Text.ToString() == "Да")
                    {
                        _pr[i] = int.Parse(textBox[DIC[key][i]].Text) * ques[DIC[key][i]].pr;
                        userMoney = int.Parse(textBox[DIC[key][i]].Text);
                    }
                }
                PR[j] = 0;
                for (int i = 0; i < _pr.Length; i++)
                {
                    PR[j] += _pr[i] * (1 - PR[j]);
                    
                }
                j++;
            }
            int Index = Array.FindIndex(PR, w => w == PR.Max());          

            Answer Answer = new Answer(ques[Index], PR[Index]);           

                if (userMoney < Answer.Rule.pr)
            {
                DialogResult dialogResult = MessageBox.Show("У Вас недостаточно средств для посещения места!", "Предупреждение", MessageBoxButtons.OK);
            }

            Hide();
            Answer.ShowDialog();
            Close();
        }
    }
}
