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
        internal class Child
        {
            // fields
            private string name;
            private DateTime birthDate;
            private int schoolId;
            private int id;

            Child(string name, DateTime birthDate, int schoolId, int id)
            {
                this.name = name;
                this.birthDate = birthDate;
                this.schoolId = schoolId;
                this.id = id;
            }
            public string Name { get; set; }
            public int Id { get; set; }
            public DateTime BirthDate { get; set; }
            public string SchoolId { get; set; }

            public int GetAge()
            {
                var today = DateTime.Today;

                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (this.birthDate.Year * 100 + this.birthDate.Month) * 100 + this.birthDate.Day;

                return (a - b) / 10000;
            }

        }
}
