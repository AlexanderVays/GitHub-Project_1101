using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileCounter
{
    public partial class PhrasesCountControl : UserControl
    {
        public PhrasesCountControl()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            List<string> inputList = new List<string> { textBox1.Text, textBox2.Text, textBox3.Text};
            inputList.RemoveAll(item => item == null || item == "");
            bool caseSensitive = checkBoxCaseSensitive.Checked;
            Reader.GetCount(inputList, caseSensitive);
            CountResultForm f2 = new CountResultForm(2);
            f2.ShowDialog();
        }
    }
}
