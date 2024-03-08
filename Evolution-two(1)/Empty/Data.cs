using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_two_1_
{
    public static class Data
    {
       
        public static int TotalExpense; 
        public static int id=6;

        public static Dictionary<int, string> D = new Dictionary<int, string>();

        public static List<CExpense> ExpenseData = new List<CExpense>();

        public static HashSet<string> CatogoryCollection = new HashSet<string>();




        public static Dictionary<int, string> CatogoryId= new Dictionary<int, string>();
        public static Dictionary<DateTime, List<Catogory>> CatogoryToMonthLimit = new Dictionary<DateTime, List<Catogory>>();
        public static Dictionary<DateTime, List<Catogory>> CurrentCatogoryToMonthLimit = new Dictionary<DateTime, List<Catogory>>();




        public static Dictionary<DateTime, int> Limit = new Dictionary<DateTime, int>();
        public static Dictionary<DateTime, int> CurrentLimit = new Dictionary<DateTime, int>(); 
       

      

    }
}
