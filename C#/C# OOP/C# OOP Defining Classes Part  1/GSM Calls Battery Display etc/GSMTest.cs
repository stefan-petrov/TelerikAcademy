using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDefiningClassesPart1
{
    class GSMTest
    {

        static void Main()
        {
            List<MobileDevice> devices = new List<MobileDevice>();
            MobileDevice gsm1 = new MobileDevice("Explorer", "HTC");
            MobileDevice gsm2 = new MobileDevice("3G", "IPhone", 460);
            MobileDevice gsm3 = new MobileDevice("S55", "Siemens", 500, "Az");
            devices.Add(gsm1);
            devices.Add(gsm2);
            devices.Add(gsm3);

            foreach (MobileDevice telefon in devices)
            {
                Console.WriteLine(telefon.ToString());
                Console.WriteLine();
            }

            Console.WriteLine(gsm3.IPshone4S.Price);

            Console.WriteLine();
            Battery bat = new Battery(BatteryType.LiIon);
            MobileDevice nokia3310 = new MobileDevice("3310", "nokia");
            nokia3310.AddToCallHistory(6548464, 22.13);
            List<Call> lc  = nokia3310.CallHistory;
            
            foreach (var item in lc)
            {
                Console.WriteLine(item);
            }
        }
    }
}
