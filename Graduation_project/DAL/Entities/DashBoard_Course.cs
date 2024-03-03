using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class DashBoard_Course
    {



        public int Dash_Id { get; set; }
        public DashBoard DashBoard { get; set; }


        public int Course_Id { get; set; }

        public Courses Course { get; set; }


    }
}
