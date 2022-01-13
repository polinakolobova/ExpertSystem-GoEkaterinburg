using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert_System
{
    public struct Rule
    {
        public string option;
        public string question;
        public string answer;
        public string adress;
        public int pr;
        public Rule(string option , string question, string answer, string adress, int pr)
        {
            this.option = option;
            this.answer = answer;
            this.question = question;
            this.adress = adress;
            this.pr = pr;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
