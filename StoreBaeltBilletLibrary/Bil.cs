using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class Bil : Køretøj
    {

        public bool WeekendRabat => Dato.DayOfWeek == DayOfWeek.Sunday || Dato.DayOfWeek == DayOfWeek.Saturday;

        public override decimal Pris()
        {
            return 240;
        }

        public override string KøretøjType()
        {
            return "Bil";
        }

        /// <summary>
        /// Totalpris udregnet med brobizz og weekendrabat
        /// </summary>
        /// <returns></returns>
        public override decimal TotalPris()
        {
            decimal _pris = Pris();
            if (WeekendRabat) //20% rabat for weekend
                _pris = _pris - (_pris / 100 * 20);

            if (Brobizz) //5% rabat for brobizz, fratrukket efter weekendrabatten
                _pris = _pris - (_pris / 100 * 5);

            return _pris;
        }

        public override DateTime Dato { get; set; }
        public override bool Brobizz { get; set; }
    }
}
