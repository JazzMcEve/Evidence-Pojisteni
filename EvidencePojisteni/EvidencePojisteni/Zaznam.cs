using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Zaznam
    {
        /// <summary>
        /// konstruktor záznamu pojištěných s vlastnostmi pro zápis a čtení proměnných
        /// </summary>
        public string CeleJmeno { get; set; }
        public int vek { get; set; }
        public int telefon { get; set; }
        public Zaznam(string celeJmeno, int vek, int telefon)
        {
            this.CeleJmeno = celeJmeno;
            this.vek = vek;
            this.telefon = telefon;
        }
        /// <summary>
        /// výpis pomocí ToStringu
        /// </summary>
        /// <returns>vrací textový řetězec Zaznam</returns>
        public override string ToString()
        {
            return CeleJmeno + "\t" + vek + "\t" + telefon;
        }
    }
}
