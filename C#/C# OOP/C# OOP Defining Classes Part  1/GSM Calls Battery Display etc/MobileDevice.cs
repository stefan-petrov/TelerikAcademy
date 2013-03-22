using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDefiningClassesPart1
{
    class MobileDevice
    {
        private string model;
        private string manifacturer;
        private decimal price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();
        static MobileDevice iPhone4S = new MobileDevice("4S", "Apple", 600,"pesho", new Battery(48,4), new Display(4, 32000000)) ;
        private List<Call> callHistory;
        private decimal pricePerMinute = 0.4m;

        public  MobileDevice IPshone4S
        {
            get { return iPhone4S; }
           
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manifacturer
        {
            get { return this.manifacturer; }
            set { this.manifacturer = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public MobileDevice(string model, string manifacturer)
        {
            this.model = model;
            this.manifacturer = manifacturer;
            this.callHistory = new List<Call>();
            this.battery = new Battery();
            this.display = new Display();
        }

        public MobileDevice(string model, string manifacturer, decimal price)
            : this(model, manifacturer)
        {
            this.price = price;
            this.callHistory = new List<Call>();
            this.battery = new Battery();
            this.display = new Display();
        }

        public MobileDevice(string model, string manifacturer, decimal price, string owner)
            : this(model, manifacturer, price)
        {
            this.owner = owner;
            this.callHistory = new List<Call>();
            this.battery = new Battery();
            this.display = new Display();
        }

        public MobileDevice(string model, string manifacturer, decimal price, string owner, Battery battery)

            : this(model, manifacturer, price, owner)
        {
            this.battery = battery;
            this.callHistory = new List<Call>();
            this.battery = new Battery();
            this.display = new Display();
        }

        public MobileDevice(string model, string manifacturer, decimal price, string owner, Battery battery, Display display)

            : this(model, manifacturer, price, owner, battery)
        {
            this.display = display;
            this.callHistory = new List<Call>();
            this.battery = new Battery();
            this.display = new Display();
        }

        public override string ToString()
        {
            return string.Format("Model: {0} \nManifacturer: {1} \nPrice: {2} \nOwner: {3}", this.model, this.manifacturer, this.price, this.owner);
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
        }

        public void AddToCallHistory(ulong dialedPhone, double duration)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            Call newCall = new Call(DateTime.Now.Date, time, dialedPhone, duration);
            CallHistory.Add(newCall);
        }

        public void RemoveFromCallHistory()
        {
            CallHistory.RemoveAt(callHistory.Count - 1);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal CallsPrice()
        {
            decimal totalPrice = 0;

            foreach (Call call in CallHistory)
            {
                totalPrice += (decimal)call.Duration * this.pricePerMinute;
            }
            return totalPrice;

        }
    }
}
