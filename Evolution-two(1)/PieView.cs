using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Evolution_two_1_
{
    public partial class PieView : Form
    {
        public PieView()
        {
            InitializeComponent();
        }
        private DateTime T;

        private Random random = new Random();
        private void button4_Click(object sender, EventArgs e)
        {
            // panel1.Invalidate();
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Enter Valid Data", "Invalid Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance |
                 BindingFlags.NonPublic, null, panel1, new object[] { true });

                PaintThePie();
            }
        }

        private void PaintThePie()
        {
            Graphics G = panel1.CreateGraphics();
            Graphics G2 = panel3.CreateGraphics();
            try
            {
                T = new DateTime(int.Parse(textBox2.Text), int.Parse(textBox1.Text), 1);
            }
            catch (Exception x)
            {
                MessageBox.Show("Enter valid Month Year");
            }

            //if (Data.CatogoryToMonthLimit.ContainsKey(T))
            Dictionary<string, int> D = new Dictionary<string, int>();
            foreach(CExpense Row in Data.ExpenseData)
            {
                DateTime CurrDate = new DateTime(Row.Date.Year, Row.Date.Month, 1);

                if (CurrDate.Equals(T))
                {
                    if (D.ContainsKey(Row.Category))
                    {
                        D[Row.Category] += Row.Amount;
                    }
                    else
                    {
                        D.Add(Row.Category, Row.Amount);
                    }
                }
            }
            {
                
                int Count = D.Count, Total = 0;
                foreach (var i in D) Total += i.Value;

                List<int> Percentages = new List<int>();
                List<float> Percentages2 = new List<float>();

                foreach (var i in D)
                {

                    float C1 = ((float)i.Value / (float)Total) *360f;
                    float C2 = ((float)i.Value / (float)Total) * 100;
                    Percentages.Add((int)C1);
                    Percentages2.Add(C2);
                }

                G.SmoothingMode = SmoothingMode.AntiAlias;
               
         

                
               
                List<Color> ColorsList = new List<Color>();

                for(int i = 0; i < D.Count; i++)
                {
                    int red = random.Next(150, 256);
                    int green = random.Next(150, 256);
                    int blue = random.Next(150, 256);

                    Color randomColor = Color.FromArgb(red, green, blue);
                    ColorsList.Add(randomColor);
                }


                
                int indexC = 0;
                foreach (var j in D) {
                  
                            // KeyForC = i.Key;
                            TextBox t = new TextBox();
                            t.Height = 20;
                            t.Text = j.Key;
                            t.BackColor = ColorsList[indexC++];
                            t.Dock = DockStyle.Top;
                            panel2.Controls.Add(t);


                          

                        
                    
                }

                int Start = 0, c = 0, Start2 = 0,c2=0 ;

                foreach(var i in Percentages2)
                {
                    int RecWidth =(int)(i * ((float)panel3.Width / 100f)),RecHeight=panel3.Height;
                    Brush B = new SolidBrush(ColorsList[c2]);
                    G2.FillRectangle(B, Start2, 0, RecWidth, RecHeight);
                    G2.DrawString(D.ElementAt(c2).Key, this.Font, Brushes.Red, new PointF(Start2 +(RecWidth/2-RecWidth/4), RecHeight / 2 - RecHeight / 4));
                   
                    Start2 += RecWidth;
                    c2++;
                }
                foreach (var i in Percentages)
                {
                    Brush B = new SolidBrush(ColorsList[c]);
                    G.FillPie(B,5,5, panel1.Width-10, panel1.Height-10,Start,i);
                 
                    Start += i;
                    c++;
                }
                using(Pen p=new Pen(Color.Black, 3))
                {
                    G.DrawEllipse(p, 5, 5, panel1.Width - 10, panel1.Height - 10);
                }

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
