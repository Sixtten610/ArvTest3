using System.Collections.Generic;
using System;

namespace ArvTest3
{
    public class Student
    {
        protected static Random generator = new Random();
        public string name;

        protected int[] subjects = new int[5];

        protected int subjectMath;
        protected int subjectEnglish;
        protected int subjectDaodac;
        protected int subjectAnimation;

        public virtual void Biography()
        {
            System.Console.WriteLine("no information");
        }
    }
}
