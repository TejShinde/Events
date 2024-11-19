//Event not written in namespace,it will write in class & interface. bcz it member of class and  interface.
//event --> delegate -->method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void DisplayMessage();
    internal class Student
    {// event
        public event DisplayMessage Pass;// it is an event name
        public event DisplayMessage Fail;

        public void AcceptMarks(int marks)
        {
            if (marks >= 40)
            {
                Pass();  // raise an event /  call to event
            }
            else
            {
                Fail();
            }
        }
    }
}
