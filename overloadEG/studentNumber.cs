using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadEG
{
    class studentNumber : studentDetail
    {

        public string studentID { set; get; }
        public studentNumber(string studentID)
        {
            this.studentID = studentID;
        }
        public studentNumber() { }

        

        public override void studentDetails()
        {
            firstName = "Steve";
            lastName = "Harvey";
            studentID = "12121212";
            Console.WriteLine("Student details: " + firstName + " " + lastName + ". StudentID" + studentID );
        }

    }
}
