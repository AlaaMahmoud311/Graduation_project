using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Question : BaseEnities
    {


        public int quize_id { get; set; }
        public Quizes Quizes { get; set; }  
        public string question_Header { get; set; } 

        public int Track_id { get; set; }
        public string Right_answer { get; set; }

        public ICollection<Choices> Choices { get; set; }   

     


    }
}
