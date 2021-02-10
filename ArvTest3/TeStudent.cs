using System;

namespace ArvTest3
{
    public class TeStudent : Student
    {
        public TeStudent(string name)
        {
            base.name = name;

            for (int i = 0; i < subjects.Length; i++)
            {
                subjects[i] = generator.Next(0, 5);
            }
        }

        public override void Biography()
        {
            System.Console.WriteLine("TeStudents are genreally better at Logical subjects");
        }


    }
}
