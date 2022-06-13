/*
 * Naam: Steffan van der Werf
 * Datum : 10-06-2022
 * Korte beschrijving : maken ouderbijdragen programma voor een school
 * Opdracht: 2 
 * Bijgeleidende docent: Rob Loves
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderBijdragen
{
    internal class School
    {
        // fields
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Child> Children { get; set; }
        public List<ParentContribution> Pcs { get; set; }

        //Constructor
        public School(string name, int id)
        {
            this.Id = id;
            this.Name = name;
            this.Children = new List<Child>();
            this.Pcs = new List<ParentContribution>();
        }
        
        public void AddChild(Child child)
        {
            this.Children.Add(child);
        }
        public void AddPc(ParentContribution pc)
        {
            this.Pcs.Add(pc);
        }
        public int GetYoungestChild()
        {
            if (this.Children.Count == 0) { return 0; }
            int age = 0;
            Child curChild = Children.First<Child>();

            foreach (Child child in Children)
            {
                if (child.GetAge() <= curChild.GetAge())
                {
                    age = child.GetAge();
                    curChild = child;
                    Console.WriteLine(age);
                }
            }
            return age;
        }
        public float GetTotalProfit() {
            if (this.Pcs.Count == 0) { return 0; }
            float total = 0;

            foreach (ParentContribution pc in Pcs)
            {
                total += pc.CalcContribution();
            }

            return total;
        }
        public int GetCountChildPerCat(int minAge, int maxAge) {
            if (this.Children.Count == 0) { return 0; }
            int counter = 0;

            foreach (Child child in Children)
            {
                if (minAge < child.GetAge() && maxAge > child.GetAge())
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
