using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDefiningClassesPart1
{
    class Battery
    {
        private BatteryType batteryType;
        private string model;
        private decimal hoursIdle;
        private decimal hoursTalk;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public decimal HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public decimal HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public Battery()
        {
        }

        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(decimal hoursIdle)
        {
            this.hoursIdle = hoursIdle;
        }

        public Battery(decimal hoursIdle, decimal hoursTalk)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public Battery(BatteryType batteryType)
        {
            this.batteryType = batteryType;
        }

        public Battery(string model, decimal hoursIdle)
            : this(model)
        {
            this.hoursIdle = hoursIdle;
        }

        public Battery(string model, decimal hoursIdle, decimal hoursTalk)
            : this(model, hoursIdle)
        {
            this.hoursTalk = hoursTalk;
        }
    }
}
