using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
   public class DashBoard : BaseEnities
    {
        
     public    string name { get; set; }   
      
      public    string email { get; set; }
       
        public int? age { get; set; } 

       public  string? phone { get; set; }

        public string? Image {  get; set; } 

        public string Job { get; set; } 

      public ICollection<Courses> Courses { get; set; }
        public ICollection<Tracks> tracks { get; set; }


    }
}
