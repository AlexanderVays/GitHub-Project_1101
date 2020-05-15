using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileCounter
{
    public partial class CountResultForm : Form
    {
        public CountResultForm(int index)
        {
            InitializeComponent();
            LoadData(index);
        }

        public void LoadData(int index) 
        {
            string selection = index == 1 ? "words" : "phrases";
            mainText.Text = $"Please find results for {selection} counting";
            text1.Text = Reader.resultDictionary.Count > 0 ? Reader.resultDictionary.Keys.ElementAt(0) : "";
            result1.Text = Reader.resultDictionary.Count > 0 ? Reader.resultDictionary[Reader.resultDictionary.Keys.ElementAt(0)].ToString() : "";
            text2.Text = Reader.resultDictionary.Count > 1 ? Reader.resultDictionary.Keys.ElementAt(1) : "";
            result2.Text = Reader.resultDictionary.Count > 1 ? Reader.resultDictionary[Reader.resultDictionary.Keys.ElementAt(1)].ToString() : "";
            text3.Text = Reader.resultDictionary.Count > 2 ? Reader.resultDictionary.Keys.ElementAt(2) : "";
            result3.Text = Reader.resultDictionary.Count > 2 ? Reader.resultDictionary[Reader.resultDictionary.Keys.ElementAt(2)].ToString() : "";
            text4.Text = Reader.resultDictionary.Count > 3 ? Reader.resultDictionary.Keys.ElementAt(3) : "";
            result4.Text = Reader.resultDictionary.Count > 3 ? Reader.resultDictionary[Reader.resultDictionary.Keys.ElementAt(3)].ToString() : "";
            text5.Text = Reader.resultDictionary.Count > 4 ? Reader.resultDictionary.Keys.ElementAt(4) : "";
            result5.Text = Reader.resultDictionary.Count > 4 ? Reader.resultDictionary[Reader.resultDictionary.Keys.ElementAt(4)].ToString() : "";
            text6.Text = Reader.resultDictionary.Count > 5 ? Reader.resultDictionary.Keys.ElementAt(5) : "";
            result6.Text = Reader.resultDictionary.Count > 5 ? Reader.resultDictionary[Reader.resultDictionary.Keys.ElementAt(5)].ToString() : "";
            Reader.resultDictionary.Clear();
        }

        private void buttonOkResult_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
