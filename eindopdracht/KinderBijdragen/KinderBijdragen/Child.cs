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
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public int SchoolId { get; set; }
        public Child(string name, DateTime birthDate, int schoolId, int id)
        {
            this.Name = name;
            this.Id = id;
            this.BirthDate = birthDate;
            this.SchoolId = schoolId;
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;

            int getNumberToday = (today.Year * 100 + today.Month) * 100 + today.Day;
            int getNumberBirthDay = (this.BirthDate.Year * 100 + this.BirthDate.Month) * 100 + this.BirthDate.Day;
            return (getNumberToday - getNumberBirthDay) / 10000;
        }
    }
}
