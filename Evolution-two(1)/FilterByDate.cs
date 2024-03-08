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
    public partial class FilterByDate : Form
    {
        private DateTime d2;
        public EventHandler<Xdates> Change;
        public FilterByDate()
        {
            InitializeComponent();
        }

        public DateTime D1 { get; set; }
        public DateTime D2 { get => d2; set => d2 = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            D1 = datePicker1.Value.Date;
            D2 = datePicker2.Value.Date;

            //ExpenseManager E = new ExpenseManager();

            Xdates X = new Xdates(D1, D2);
            Change?.Invoke(sender,X);
            this.Hide();
        }
    }
}
