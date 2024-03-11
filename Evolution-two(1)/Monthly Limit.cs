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
    public partial class Monthly_Limit : Form
    {
        public Monthly_Limit()
        {
            InitializeComponent();
            comboBox1.DataSource = (Data.CatogoryCollection).ToList<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox2.Text.Equals("") || comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Enter Valid Data", "Invalid Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                int Month = int.Parse(textBox1.Text), Year = int.Parse(textBox2.Text), Amount = int.Parse(textBox3.Text);
                DateTime T = new DateTime(Year, Month, 1);
                try
                {
                    Data.Limit.Add(T, Amount);

                    foreach (var i in Data.ExpenseData)
                    {
                        DateTime CurrentTime = new DateTime(i.Date.Year, i.Date.Month, 1);
                        if (Data.CurrentLimit.ContainsKey(CurrentTime))
                        {
                            Data.CurrentLimit[CurrentTime] += i.Amount;
                        }
                        else
                        {
                            Data.CurrentLimit[CurrentTime] = i.Amount;
                        }
                    }
                    MessageBox.Show(" Limit Setted for " + Month + "/" + Year + "Month");
                }
                catch
                {
                    MessageBox.Show(" Limit Already Setted for this Month");
                }
                this.Hide();
            }
        }
        int KeyForC;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox2.Text.Equals("") || comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Enter Valid Data", "Invalid Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                int Month = int.Parse(textBox1.Text), Year = int.Parse(textBox2.Text), Amount = int.Parse(textBox3.Text);
                string Catogory = comboBox1.SelectedItem.ToString();


                foreach (var i in Data.CatogoryId)
                {
                    if (i.Value.Equals(Catogory))
                    {
                        KeyForC = i.Key;
                        break;

                    }
                }
                try
                {
                    DateTime T = new DateTime(Year, Month, 1);

                    if (Data.CatogoryToMonthLimit.ContainsKey(T))
                    {
                        List<Catogory> L = Data.CatogoryToMonthLimit[T];
                        int flag1 = 0;
                        foreach (Catogory i in Data.CatogoryToMonthLimit[T])
                        {
                            if (KeyForC == i.Id)
                            {
                                i.Limit = Amount;
                                flag1 = 1;
                                break;
                            }
                        }

                        if (flag1 == 0)
                        {
                            L.Add(new Catogory(KeyForC, Amount, 0));
                            Data.CatogoryToMonthLimit[T] = L;
                        }
                    }
                    else
                    {
                        List<Catogory> L = new List<Catogory>() { new Catogory(KeyForC, Amount, 0) };
                        Data.CatogoryToMonthLimit.Add(T, L);
                        //  MessageBox.Show("1.Limit Setted for " + Catogory + "in" + Month + "/" + Year + "Month");
                    }
                    MessageBox.Show(" Limit Setted for " + Catogory + " in " + Month + "/" + Year + " Month");
                }
                catch (Exception X)
                {
                    MessageBox.Show(" Limit Already Setted for this Month");
                }
                this.Hide();
            }
        }
    }
}
