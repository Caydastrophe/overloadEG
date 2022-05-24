using System;

namespace overloadEG
{
    class Program
    {
        static void Main(string[] args)
        {
            studentDetail student = new studentDetail();
            student.studentDetails();

            studentNumber student2 = new studentNumber();
            student2.studentDetails();

        }
    }
}
