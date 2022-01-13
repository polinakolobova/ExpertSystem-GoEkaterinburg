using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Expert_System
{
    public partial class Options : Form
    {
        public List<Rule> RulesList;
        public Options(List<Rule> RulesList)
        {
            this.RulesList = RulesList;
            int i = 0;
            int size = RulesList.Select(r => r.option).Distinct().Count();
            InitializeComponent();
            RadioButton[] options = new RadioButton[size];
            if(size > 3)
            {
                groupBox1.Size = new Size(150,20 + 30 * size);
                this.Size = new Size(166,100 + 30 *size);
            }
            foreach (string option in RulesList.Select(r => r.option).Distinct().ToList())
            {
                options[i] = new RadioButton();
                options[i].AutoSize = true;
                options[i].Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                options[i].Location = new Point(6, 20 + 30 * i);
                options[i].Name = "option" + i;
                options[i].Text = option;
                options[i].CheckedChanged += new EventHandler(this.options_CheckedChanged);
                groupBox1.Controls.Add(options[i]);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Questions Questions = new Questions(RulesList, checkedButton.Text);
            Hide();
            Questions.ShowDialog();
            Close();
        }

        private void options_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
