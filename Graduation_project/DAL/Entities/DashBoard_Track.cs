using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public  class DashBoard_Track
    {
        public int Dash_Id { get; set; }    

        public DashBoard DashBoard { get; set; }

        public int Track_Id { get; set; }   

        public Tracks Tracks { get; set; }  



    }
}
