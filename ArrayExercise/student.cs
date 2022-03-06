using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    public class student
    {
        private int student_id;
        private string student_name;
        private string student_description;

        //Constructor
        public int Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }

        public string Student_Name
        {
            get { return student_name; }
            set { student_name = value; }
        }
        public string Student_Description { get; set; }

    }
}
