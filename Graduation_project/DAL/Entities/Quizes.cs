using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Quizes : BaseEnities
    {




        public int Score { get; set; }
        public int Track_id { get; set; }
        public Tracks Track { get; set; }  

        


        public ICollection<Question> Questions { get; set; }    





    }
}
