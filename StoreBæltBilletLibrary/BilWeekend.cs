using System;
using BilletLibrary;

namespace StoreBæltBilletLibrary
{
    public class BilWeekend : Vehicle
    {
        private string _nummerPlade;

        public string NummerPlade
        {
            get => _nummerPlade;
            set => _nummerPlade = value.Length <= 7 ? value
                : throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn!");
        }
        
        public DateTime Dato { get; set; }
        public bool Brobizz { get; set; }
        
        /// <summary>
        /// Returns the price formatted as decimal.
        /// If Brobizz is set to true then the price is reduced by 5%.
        /// </summary>
        public override decimal Pris()
        {
            if (Dato.DayOfWeek.Equals(DayOfWeek.Saturday) || Dato.DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                decimal p = 0;
                p = 240 - ((240 * 20) / 100);
                return !Brobizz ? p : p - ((p * 5) / 100);
            }
            return !Brobizz ? 240 : 240 - ((240 * 5) / 100);
        }

        /// <summary>
        /// Returns which type of vehicle this is formatted as string.
        /// </summary>
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
