using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMVP2
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            comboBoxOperation.SelectedIndex = 0;
        }

        public int FirstValue
        {
            get
            {
                return decimal.ToInt32(numericUpDown1.Value);
            }
            set
            {
                numericUpDown1.Value = value;
            }
        }
        public int SecondValue
        {
            get
            {
                return decimal.ToInt32(numericUpDown2.Value);
            }
            set
            {
                numericUpDown2.Value = value;
            }
        }
        public string SelectedOperator
        {
            get
            {
                return comboBoxOperation.SelectedItem.ToString();
            }
            set
            {
                comboBoxOperation.SelectedItem = value;
            }
        }
        public string AnswerValue
        {
            get
            {
                return labelValue.Text;
            }
            set
            {
                labelValue.Text = value;
            }

        }

        public event Func<int, string, int, string> ViewCalculate;

        private void button1_Click(object sender, EventArgs e)
        {
            AnswerValue = ViewCalculate(FirstValue, SelectedOperator, SecondValue);
        }
    }
}
