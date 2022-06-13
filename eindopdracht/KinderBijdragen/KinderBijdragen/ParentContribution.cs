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
        public Child Child { get; set; }
        public ParentContribution(Child child)
        {
            this.Child = child;
        }
                
        public float CalcContribution()
        {
            if (Child == null) { return 0; }
            float contribution = 0;

            switch (Child.GetAge())
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
