using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFileCounter
{
    public partial class WordsCountControl : UserControl
    {
        public WordsCountControl()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            List<string> wordsList = new List<string> { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            wordsList.RemoveAll(item => item == null || item == "");
            bool caseSensitive = checkBoxCaseSensitive.Checked;
            Reader.GetCount(wordsList, caseSensitive);
            CountResultForm resultForm = new CountResultForm(1);
            resultForm.ShowDialog();
        }

        /*private void resultForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Reader.resultDictionary.Clear();
        } */
    }
}
