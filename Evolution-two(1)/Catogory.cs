using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_two_1_
{
    public class Catogory
    {
        public  int Id;
        public  int Limit;
        public int RowIndex;

        public Catogory(int id,int limit,int r) 
        {
            Id = id;Limit = limit;RowIndex = r;
        }
        
    }
}
