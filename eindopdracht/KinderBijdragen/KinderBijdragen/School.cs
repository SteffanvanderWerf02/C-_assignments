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
        private string name;
        private int id;
        private List<Child> childeren;
        private List<ParentContribution> pcs;

        //Constructor
        School(string name, int id, List<Child> childeren, List<ParentContribution> pc)
        {
            this.name = name;
            this.id = id;
            this.childeren = childeren;
            this.pcs = pc;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Child> Children { get; set; }
        public List<ParentContribution> Pc { get; set; }
        public void AddChild(Child child)
        {
            this.Children.Add(child);
        }
        public void AddPc(ParentContribution pc)
        {
            this.pcs.Add(pc);
        }
        public int GetYoungestChild()
        {
            int age = 0;
            Child curChild = Children.First<Child>();

            foreach (Child child in Children)
            {
                if (curChild.GetAge() <= child.GetAge())
                {
                    age = child.GetAge();
                    curChild = child;
                }
            }
            return age;
        }
        public float getTotalProfit() {
            float total = 0;

            foreach (ParentContribution pc in pcs)
            {
                total += pc.CalcContribution();
            }

            return total;
        }
        public int getCountChildPerCat(int age) {
            int counter = 0;

            foreach (Child child in Children)
            {
                if (age < child.GetAge())
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
