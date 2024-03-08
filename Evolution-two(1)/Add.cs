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
    public partial class Add : Form
    {
        public CExpense C;
        public EventHandler<CExpense> E;
        public Add()
        {
            InitializeComponent();
        
            comboBox1.DataSource = (Data.CatogoryCollection).ToList<string>();


        }

        private void Expense_Load(object sender, EventArgs e)
        {

        }

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
