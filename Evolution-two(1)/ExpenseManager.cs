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
    
    public partial class ExpenseManager : Form
    {
        private int tempId=5;
        private int index;
        private int Total = 0;
        private DataTable D;
        public EventHandler<int> E;

        Rectangle[]  Element=new Rectangle[10];

        public ExpenseManager()
        {
            InitializeComponent();
            D = new DataTable();
            D.Columns.Add("Category", typeof(string));
            D.Columns.Add("Amount", typeof(int));
            D.Columns.Add("Date", typeof(DateTime));
            D.Columns.Add("Description", typeof(string));

            Data.CatogoryCollection.Add("All");
            Data.CatogoryCollection.Add("Travel");
            Data.CatogoryCollection.Add ("Gaming");
            Data.CatogoryCollection.Add("Food");
            Data.CatogoryCollection.Add("Movies");

            Data.CatogoryId.Add(1,"All");
            Data.CatogoryId.Add(2,"Travel");
            Data.CatogoryId.Add(3,"Gaming");
            Data.CatogoryId.Add(4,"Food");
            Data.CatogoryId.Add(5,"Movies");


            dataGridView1.DataSource = D;
            comboBox1.DataSource = (Data.CatogoryCollection).ToList<string>();




            //Element[0] = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            //Element[1] = new Rectangle(AddButton.Location.X,AddButton.Location.Y,AddButton.Width,AddButton.Height);
            //Element[2] = new Rectangle(RemoveButton.Location.X,RemoveButton.Location.Y,RemoveButton.Width,RemoveButton.Height);
            //Element[3] = new Rectangle(EditButton.Location.X,EditButton.Location.Y,EditButton.Width,EditButton.Height);
            //Element[4] = new Rectangle(button1.Location.X,button1.Location.Y,button1.Width,button1.Height);
            //Element[5] = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            //Element[6] = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            //Element[7] = new Rectangle(comboBox1.Location.X, comboBox1.Location.Y, comboBox1.Width, comboBox1.Height);


        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
           
            Add Add = new Add();
            Add.Show();

            
            Add.E += InitializeExpenseRow; 

            dataGridView1.DataSource = D;
            tempId++;


        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount >0) {
                E?.Invoke(sender, index);
                Edit edit = new Edit();
                edit.Index = index;
                edit.Show();


                edit.E += InitializeExpenseRow2;

                dataGridView1.DataSource = D;
            }

           
           else
            {
                MessageBox.Show("Select Valid Row");
             //   this.Visible = false;
            }
            //  E?.Invoke(sender, index);
        }

        private void InitializeExpenseRow(object s, CExpense C)
        {
          
         
            DateTime CurrMonth = new DateTime(C.Date.Year, C.Date.Month,1);
           
            int flag = 0;
            int flag1 = 0;
            int flag2 = 0;


            int KeyForC =-1;
            foreach (var i in Data.CatogoryId)
            {
                if (i.Value.Equals(C.Category))
                {
                    KeyForC = i.Key;
                    break;

                }
            }
            int CurrentLimit = 0;
            if (Data.CatogoryToMonthLimit.ContainsKey(CurrMonth))
            {
                foreach(var i in Data.CatogoryToMonthLimit)
                {
                    List<Catogory> L1 = i.Value;
                    foreach(var j in L1)
                    {
                        if (j.Id == KeyForC)
                        {
                            CurrentLimit = j.Limit;
                        }
                    }
                }
                List<Catogory> L;
                if (Data.CurrentCatogoryToMonthLimit.ContainsKey(CurrMonth))
                {
                    L = Data.CurrentCatogoryToMonthLimit[CurrMonth];
                    for (int i = 0; i < L.Count; i++)
                    {
                        if (L[i].Id == KeyForC)
                        {
                            flag2 = 1;

                            if (L[i].Limit+C.Amount > CurrentLimit)
                            {
                                flag1 = 1;
                                MessageBox.Show("Your Limit Exceeded For " + C.Category + " in " + CurrMonth.Month + "/" + CurrMonth.Year + " Month");
                            }
                            else
                            {
                                L[i].Limit += C.Amount;
                            }
                        }
                    }

                    if (flag2 == 0)
                    {
                        L.Add(new Catogory(KeyForC, C.Amount, index));
                        Data.CurrentCatogoryToMonthLimit[CurrMonth]=L;
                    }
                }
                else
                {
                     L = new List<Catogory>();
                     L.Add(new Catogory(KeyForC, C.Amount,index));
                     Data.CurrentCatogoryToMonthLimit.Add(CurrMonth , L);
                }
                
            }




            if (Data.Limit.ContainsKey(CurrMonth))
            {
                if (Data.CurrentLimit.ContainsKey(CurrMonth))
                {
                    if (Data.CurrentLimit[CurrMonth]+C.Amount > Data.Limit[CurrMonth])
                    {
                        flag = 1;
                        MessageBox.Show("Your Limit Exceeded For " + CurrMonth.Month + "/" + CurrMonth.Year + "  vMonth");
                        
                    }
                    else
                    {
                        Data.CurrentLimit[CurrMonth] += C.Amount;
                        //   Data.ExpenseData.Add(C);
                        //  Data.D.Add(tempId, C.Category);
                    }

                }
                else
                {
                    Data.CurrentLimit.Add(CurrMonth, C.Amount);
                }
            }

          //  if (flag == 0 && flag1==0)
           // {
                D.Rows.Add(C.Category, C.Amount, C.Date, C.Description);
                Total += C.Amount;
                label2.Text = "Total : " + Total + "/-";
                Data.ExpenseData.Add(C);
                Data.D.Add(tempId, C.Category);
           // }

        }

        private void InitializeExpenseRow2(object s, CExpense C)
        {
            CExpense PrevRecord= Data.ExpenseData[index];

            DateTime CurrMonth = new DateTime(PrevRecord.Date.Year, PrevRecord.Date.Month, 1);
            int flag = 0;



            int KeyForC = -1;
            foreach (var i in Data.CatogoryId)
            {
                if (i.Value.Equals(dataGridView1.Rows[index].Cells[0].Value))
                {
                    KeyForC = i.Key;
                    break;

                }
            }

            List<Catogory> L;
            if (Data.CurrentCatogoryToMonthLimit.ContainsKey(CurrMonth))
            {
                int CurrentLimit = 0;
                foreach (var i in Data.CatogoryToMonthLimit)
                {
                    List<Catogory> L1 = i.Value;
                    foreach (var j in L1)
                    {
                        if (j.Id == KeyForC)
                        {
                            CurrentLimit = j.Limit;
                        }
                    }
                }




                L = Data.CurrentCatogoryToMonthLimit[CurrMonth];
                for (int i = 0; i < L.Count; i++)
                {
                    if (L[i].Id == KeyForC)
                    {

                        int CurrentAmount = L[i].Limit;//int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString());
                      //  L[i].Limit+=
                      //  Data.CurrentCatogoryToMonthLimit[CurrMonth] = L;
                      

                        CurrentAmount -= PrevRecord.Amount;
                        CurrentAmount += C.Amount;

                        if (CurrentAmount >= CurrentLimit)
                        {
                            flag = 1;
                            MessageBox.Show("Your Limit Exceeded For " + CurrMonth.Month + "/" + CurrMonth.Year + "Month");

                        }
                        else
                        {
                            L[i].Limit = CurrentAmount;
                            Data.CurrentCatogoryToMonthLimit[CurrMonth] = L;

                        }
                        break;



                    }
                }
            }


        











            if (Data.Limit.ContainsKey(CurrMonth))
            {
                if (Data.CurrentLimit.ContainsKey(CurrMonth))
                {

                    int CurrentAmount = Data.CurrentLimit[CurrMonth];
                    CurrentAmount -= PrevRecord.Amount;
                    CurrentAmount += C.Amount;

                    if (CurrentAmount >= Data.Limit[CurrMonth])
                    {
                        flag = 1;
                        MessageBox.Show("Your Limit Exceeded For " + CurrMonth.Month + "/" + CurrMonth.Year + "Month");
                        
                    }
                    else
                    {
                        Data.CurrentLimit[CurrMonth] = CurrentAmount;

                    }

                }
              
            }




          //  if (flag == 0)
          //  {
                Total -= Data.ExpenseData[index].Amount;
                D.Rows.RemoveAt(index);


                D.Rows.Add(C.Category, C.Amount, C.Date, C.Description);
                Data.D[C.Id] = (C.Category);
                Total += C.Amount;
                label2.Text = "Total : " + Total + "/-";
            //}







        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows[index].Selected = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Curr = (DateTime)dataGridView1.Rows[index].Cells[2].Value;
                DateTime CurrMonth = new DateTime(Curr.Year, Curr.Month, 1);

                int KeyForC = -1;
                foreach (var i in Data.CatogoryId)
                {
                    if (i.Value.Equals(dataGridView1.Rows[index].Cells[0].Value))
                    {
                        KeyForC = i.Key;
                        break;

                    }
                }

                List<Catogory> L;
                if (Data.CurrentCatogoryToMonthLimit.ContainsKey(CurrMonth))
                {
                    L = Data.CurrentCatogoryToMonthLimit[CurrMonth];
                    for (int i = 0; i < L.Count; i++)
                    {
                        if (L[i].Id == KeyForC)
                        {

                            L[i].Limit-=int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString());
                            Data.CurrentCatogoryToMonthLimit[CurrMonth] = L;
                            break;

                            
                            
                        }
                    }
                }

                if (Data.Limit.ContainsKey(CurrMonth))
                {
                    if (Data.CurrentLimit.ContainsKey(CurrMonth))
                    {
                        
                            Data.CurrentLimit[CurrMonth] -= int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString());
                        //   Data.ExpenseData.Add(C);
                        //  Data.D.Add(tempId, C.Category);
                    }

                    }






                    D.Rows.RemoveAt(index);
                Total -= Data.ExpenseData[index].Amount;
                label2.Text = "Total : " + Total + "/-";
                Data.ExpenseData.RemoveAt(index);
            }
            catch(Exception o)
            {
                MessageBox.Show("Select Valid Row");
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("All"))
            {
                dataGridView1.DataSource = D;
            }
            else 
            {
                string CategoryName = comboBox1.SelectedItem.ToString();
                DataTable DFilterTable = new DataTable();
                DFilterTable.Columns.Add("Category", typeof(string));
                DFilterTable.Columns.Add("Amount", typeof(int));
                DFilterTable.Columns.Add("Date", typeof(DateTime));
                DFilterTable.Columns.Add("Description", typeof(string));


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(comboBox1.Text))
                    {
                        DFilterTable.Rows.Add(dataGridView1.Rows[i].Cells[0].Value,
                           (dataGridView1.Rows[i].Cells[1].Value),
                          (dataGridView1.Rows[i].Cells[2].Value),
                            dataGridView1.Rows[i].Cells[3].Value);
                    }
                }
                dataGridView1.DataSource = DFilterTable;
            }
        
        }
        private DateTime D1 , D2 ;
       
        private void button1_Click(object sender, EventArgs e)
        {
            FilterByDate F = new FilterByDate();
            F.Show();

            F.Change += FilterByDate;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCatgories E = new EditCatgories();
            E.Show();

            E.Add += NewAdd;
            E.Remove += OldRemove;
        }
        private void NewAdd(object s,string a)
        {

            Data.CatogoryCollection.Add(a);
            if (!Data.CatogoryId.ContainsValue(a))
            {
                Data.CatogoryId.Add(Data.id, a);
                Data.id++;
            }
            comboBox1.DataSource = (Data.CatogoryCollection).ToList<string>();
           

        }

        private void OldRemove(object s,string a)
        {
            for(int i = 0; i < comboBox1.Items.Count; i++)
            {
              //  if (comboBox1.Items[i].Equals(a)) comboBox1.Items.RemoveAt(i);
            }

            for(int i = 0; i < Data.D.Count; i++)
            {
                if (Data.CatogoryCollection.ElementAt(i).Equals(s))
                {
                    Data.CatogoryCollection.Remove(Data.CatogoryCollection.ElementAt(i));
                }
            }

            for (int i = 0; i < Data.CatogoryId.Count; i++)
            {
                if (Data.CatogoryId.ElementAt(i).Equals(s))
                {
                    Data.CatogoryId.Remove(i);
                }
            }
            comboBox1.DataSource = (Data.CatogoryCollection).ToList<string>();
          

            for (int i = 0; i < D.Rows.Count; i++)
            {
                string x = dataGridView1.Rows[i].Cells[0].ToString();
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(a))
                {
                    D.Rows.RemoveAt(i);
                }
                dataGridView1.DataSource = D;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Monthly_Limit M = new Monthly_Limit();
            M.Show();
        }
        
        private void FilterByDate(object s,Xdates D) {

            this.D1 = D.T1; D2 = D.T2;
            string CategoryName = comboBox1.SelectedItem.ToString();
            DataTable DFilterTable = new DataTable();
            DFilterTable.Columns.Add("Category", typeof(string));
            DFilterTable.Columns.Add("Amount", typeof(int));
            DFilterTable.Columns.Add("Date", typeof(DateTime));
            DFilterTable.Columns.Add("Description", typeof(string));


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DateTime Curr = (DateTime)dataGridView1.Rows[i].Cells[2].Value;
                if ( Curr.Year>=D1.Year && Curr.Year<=D2.Year && Curr.Month>=D1.Month && Curr.Month<=D2.Month && Curr.Date>=D1.Date && Curr.Date<=D2.Date)
                {
                    DFilterTable.Rows.Add(dataGridView1.Rows[i].Cells[0].Value,
                       (dataGridView1.Rows[i].Cells[1].Value),
                      (dataGridView1.Rows[i].Cells[2].Value),
                        dataGridView1.Rows[i].Cells[3].Value);
                }
            }
            dataGridView1.DataSource = DFilterTable;
        }


        private Size Orgform;

        private void ExpenseManagerLoad(object sender, EventArgs e)
        {
            label2.Text = "Total : " + Total + "/-";

            Element[0] = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            Element[1] = new Rectangle(AddButton.Location.X, AddButton.Location.Y, AddButton.Width, AddButton.Height);
            Element[2] = new Rectangle(RemoveButton.Location.X, RemoveButton.Location.Y, RemoveButton.Width, RemoveButton.Height);
            Element[3] = new Rectangle(EditButton.Location.X, EditButton.Location.Y, EditButton.Width, EditButton.Height);
            Element[4] = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            Element[5] = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            Element[6] = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            Element[7] = new Rectangle(comboBox1.Location.X, comboBox1.Location.Y, comboBox1.Width, comboBox1.Height);
            Element[8] = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            Element[9] = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            Orgform = this.Size;

        }





        private void ExpenseManager_Resize(object sender, EventArgs e)
        {
            Resizing(Element[0], dataGridView1);
            Resizing(Element[1], AddButton);
            Resizing(Element[2], RemoveButton);
            Resizing(Element[3], EditButton);
            Resizing(Element[4], button1);
            Resizing(Element[5], button2);
            Resizing(Element[6], button3);
            Resizing(Element[7], comboBox1);
            Resizing(Element[8], label1);
            Resizing(Element[9], label2);

        }
        
        private void Resizing(Rectangle r,Control c)
        {
            float xRatio = (float)(this.Width) / (float)(Orgform.Width);
            float yRatio = (float)(this.Height) / (float)(Orgform.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newW = (int)(r.Width * xRatio);
            int newH = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);

            c.Size = new Size(newW, newH);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PieView P = new PieView();
            P.Show();
        }
    }
}
