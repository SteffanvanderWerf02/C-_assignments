using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderBijdragen
{
    internal class bubbleSort
    {
      
            private Student[] students;
            public delegate Boolean Filter(Student s1, Student s2);

            public BubbleSort(List<Student> students)
            {
                this.students = students.ToArray();
            }

            public Student[] SortData(Filter filter)
            {
                Boolean swapped;
                for (int j = 0; j < this.students.Length - 1; j++)
                {
                    swapped = false;
                    for (int i = 0; i < this.students.Length - 1; i++)
                    {
                        if (filter(this.students[i], this.students[i + 1]))
                        {
                            Student temp = this.students[i + 1];
                            this.students[i + 1] = this.students[i];
                            this.students[i] = temp;
                            swapped = true;
                        }
                    }
                }
                return this.students;
            }

            public override String ToString()
            {
                String data = "";
                foreach (Student s in this.students)
                {
                    data += $"{s.Id}, {s.Name}, {s.Age} \n";
                }
                return data;
            }

            // filter methods
            public Boolean filterName(Student s1, Student s2)
            {
                if (s1.Name.CompareTo(s2.Name) > 0)
                {
                    return true;
                }
                return false;
            }

            public Boolean filterId(Student s1, Student s2)
            {
                if (int.Parse(s1.Id) > int.Parse(s2.Id))
                {
                    return true;
                }
                return false;
            }

            public Boolean filterAge(Student s1, Student s2)
            {
                if (s1.Age > s2.Age)
                {
                    return true;
                }
                return false;
            }
        }
}
