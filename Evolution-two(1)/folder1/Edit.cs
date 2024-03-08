using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolution_two_1_
{
    public partial class Edit : Form
    {
        public CExpense C;
        public EventHandler<CExpense> E;

        public Edit()
        {
            InitializeComponent();
            comboBox1.DataSource = (Data.CatogoryCollection).ToList<string>();

            Reffresh();
        }
        private int index;

        public int Index { get => index; set { index = value; Reffresh(); } }

        private void Reffresh()
        {
           // int index = Index;

            try
            {
                textBox1.Text = Data.ExpenseData[index].Amount + "";
                comboBox1.Text = Data.ExpenseData[index].Category + "";
                datePicker1.Value = Data.ExpenseData[index].Date;
                richTextBox1.Text = Data.ExpenseData[index].Description;
            }
            catch (Exception o)
            {
                MessageBox.Show("Select Valid Row");
                this.Visible = false;
            }
        }
       
     
        //public int Index { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            C = new CExpense();
            C.Amount = int.Parse(textBox1.Text);
            C.Category = comboBox1.Text;
            C.Date = datePicker1.Value.Date;
            C.Description = richTextBox1.Text;

            E?.Invoke(sender, C);
            //this.Hide();
            this.Visible = false;
        }
    }
}
