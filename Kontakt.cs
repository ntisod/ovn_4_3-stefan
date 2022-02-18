using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4._3
{
    class Kontakt
    {
        /// <summary>
        /// Designer that creates a contact with all values.
        /// </summary>
        /// <param name="förnamn">Contacts first name</param>
        /// <param name="efternamn">Contacts surname</param>
        /// <param name="epost">Contacts emailaddress</param>
        /// <param name="telefonnr">Contacts phone number</param>


        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }
        public string Telefonnr { get; set; }

        public Kontakt(string förnamn, string efternamn, string epost, string telefonnr)
        {
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
            this.Epost = epost;
            this.Telefonnr = telefonnr;
        }
        /// <summary>
        /// Writes the contacts name
        /// </summary>
        /// <returns>This one returns the contacts first- and surname</returns>
        public override string ToString()
        {
            return Förnamn + " " + Efternamn;
        }
    }
}
