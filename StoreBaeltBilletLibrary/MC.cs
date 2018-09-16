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

        public override DateTime Dato { get; set; }
    }
}
