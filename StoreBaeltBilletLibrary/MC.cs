using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class MC : Køretøj
    {
        public override decimal Pris()
        {
            return 125;
        }

        public override string KøretøjType()
        {
            return "MC";
        }

        /// <summary>
        /// Totalpris udregnet med brobizz
        /// </summary>
        /// <returns></returns>
        public override decimal TotalPris()
        {
            decimal _pris = Pris();

            if (Brobizz) //5% rabat for brobizz, fratrukket efter weekendrabatten
                _pris = _pris - (_pris / 100 * 5);

            return _pris;
        }

        public override DateTime Dato { get; set; }
        public override bool Brobizz { get; set; }
    }
}
