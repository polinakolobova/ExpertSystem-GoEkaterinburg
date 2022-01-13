using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Expert_System
{
    public partial class Rules : Form
    {
        private string option;
        private string question;
        private string answer;        
        private string adress;
        private int pr;
        private Stream fileStream;
        private Start SF;
        public Rules(Start SF)
        {
            this.SF = SF;
            InitializeComponent();
            load();
        }

        public void load()
        {
            fileStream = new FileStream("Rules.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader SR = new StreamReader(fileStream);
            SF.RulesList = new List<Rule>();
            SF.RulesList.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            while (SR.Peek() >= 0)
            {
                option = SR.ReadLine();
                question = SR.ReadLine();
                answer = SR.ReadLine();
                adress = SR.ReadLine();
                pr = int.Parse(SR.ReadLine());
                dataGridView1.Rows.Add(option, question, answer, adress, pr.ToString());
                SF.RulesList.Add(new Rule(option, question, answer, adress, pr));
            }
            SR.Close();
            fileStream.Close();
        }

        private void save()
        {
            fileStream = new FileStream("Rules.txt", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(fileStream);
            SF.RulesList = new List<Rule>();
            SF.RulesList.Clear();
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if (!Row.IsNewRow)
                {
                    option = Row.Cells["_Option"].Value.ToString();
                    question = Row.Cells["_Question"].Value.ToString();
                    answer = Row.Cells["_Answer"].Value.ToString();
                    adress = Row.Cells["_Adress"].Value.ToString();
                    pr = int.Parse(Row.Cells["_Pr"].Value.ToString());
                    SW.WriteLine(option);
                    SW.WriteLine(question);
                    SW.WriteLine(answer);
                    SW.WriteLine(adress);
                    SW.WriteLine(pr.ToString());
                    SF.RulesList.Add(new Rule(option, question , answer, adress, pr));
                }
            }
            SW.Flush();
            SW.Close();
            fileStream.Close();
        }

        private void Rules_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }

        private void dataGridView1_CellValidating(object sender,
        DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
                dataGridView1.Columns[e.ColumnIndex].HeaderText;

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText =
                    headerText + " не должно быть пусто";
                e.Cancel = true;
            }
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (string.IsNullOrEmpty(row.Cells[dataGridView1.Columns[0].Index].Value.ToString()) ||
            string.IsNullOrEmpty(row.Cells[dataGridView1.Columns[1].Index].Value.ToString()) ||
            string.IsNullOrEmpty(row.Cells[dataGridView1.Columns[2].Index].Value.ToString()) ||
            string.IsNullOrEmpty(row.Cells[dataGridView1.Columns[3].Index].Value.ToString()) ||
            string.IsNullOrEmpty(row.Cells[dataGridView1.Columns[4].Index].Value.ToString()))
                e.Cancel = true;
        }

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }
    }
}
