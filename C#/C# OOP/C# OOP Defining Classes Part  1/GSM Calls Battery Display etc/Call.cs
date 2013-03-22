using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDefiningClassesPart1
{
    class Call
    {
        private DateTime date;
        private TimeSpan time;
        private ulong dialedPhone;
        private double duration;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public TimeSpan Time
        {
            get { return time; }
            set { time = value; }
        }

        public ulong DialedPhone
        {
            get { return dialedPhone; }
            set { dialedPhone = value; }
        }

        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public Call(DateTime date, TimeSpan time, ulong dialedPhone, double duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        public override string ToString()
        {
            return date + " " + time + " Phone number: " + dialedPhone + " " + duration + " minutes";
        }
    }
}