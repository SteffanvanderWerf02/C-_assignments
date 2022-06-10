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
    internal class ParentContribution
    {
        // fields
        private int childId;
        private Child child;

        ParentContribution(int childId, Child child)
        {
            this.childId = childId;
            this.child = child;
        }

        public int ChildId { get; set; }
        public Child Child { get; set; }
        public float CalcContribution()
        {
            float contribution = 0;

            switch (child.GetAge())
            {
                case int age when age > 6 && age < 10:
                    contribution = 38;
                    break;
                case int age when age > 6 && age < 10:
                    contribution = 50;
                    break;
                default:
                    contribution = 65;
                    break;
            }

            return contribution;
        }
    }
}
