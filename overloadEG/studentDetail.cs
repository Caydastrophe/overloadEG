using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadEG
{
    class studentDetail
    {
        public studentDetail(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public studentDetail() { }

        public string firstName { set; get; }
        public string lastName { set; get; }

        public virtual void studentDetails()
        {
            firstName = "Steve";
            lastName = "Harvey";
            Console.WriteLine("Student details: " + firstName + " " + lastName + ".");
        }
    }
}
