using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public  class Choices  : BaseEnities
    {


        

        public int Question_id { get; set; }  
        public Question Question { get; set; }  
        public string choice {  get; set; }

    }
}
