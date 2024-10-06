using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAppliance
{
    public class Madlavningsapparat : Apparat
    {
        public int Temperatur { get; set; }

        public void IndstilTemperatur(int temperatur)
        {
            Temperatur = temperatur;
        }
    }
}
