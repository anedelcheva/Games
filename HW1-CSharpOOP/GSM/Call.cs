using System;

namespace DefineClass
{
    class Call
    {
        private DateTime date_and_time;
        private string dialled_phone_number;
        private uint duration_in_seconds;

        public Call(DateTime date_and_time, string dialled_phone_number, uint duration_in_seconds)
        {
            this.date_and_time = date_and_time;
            this.dialled_phone_number = dialled_phone_number;
            this.duration_in_seconds = duration_in_seconds;
        }

        public DateTime DateAndTime { get; set; }
        public string DialledPhoneNumber { get; set; }
        public uint DurationInSeconds
        {
            get
            {
                return duration_in_seconds;
            }
        }

        public double calculateCallPrice(double price)
        {
            return (duration_in_seconds / 60.0) * price;
        }

        public override string ToString()
        {
            return "Date and time: " + this.date_and_time + "\nDialled phone number: " + dialled_phone_number + "\nDuration in seconds: " + duration_in_seconds;
        }
    }
}