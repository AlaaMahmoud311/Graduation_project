using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Tracks : BaseEnities
    {

        public  string track_Name {  get; set; }  
        
        public Quizes quize { get; set; }  

       
        
        public  ICollection<DashBoard> dashboards { get; set; }

        public ICollection<Courses> Courses{ get; set; }


    }
}
