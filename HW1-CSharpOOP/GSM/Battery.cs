using System;

namespace DefineClass
{
    public enum BatteryType
    {
        Li_Ion, NiMH, NiCd, Li_Po
    }

    class Battery
    {
        private string model;
        private double hours_idle;
        private double hours_talk;
        private BatteryType battery_type;

        public Battery(string model, double hours_idle, double hours_talk, BatteryType battery_type)
        {
            this.model = model;
            this.hours_idle = hours_idle;
            this.hours_talk = hours_talk;
            this.battery_type = battery_type;
        }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public double HoursIdle
        {
            get
            {
                return hours_idle;
            }

            set
            {
                if (hours_idle <= 0)
                    throw new ArgumentException("Hours idle cannot be less than or equal to zero");
                hours_idle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return hours_talk;
            }

            set
            {
                if (hours_talk <= 0)
                    throw new ArgumentException("Hours talk cannot be less than or equal to zero");
                hours_talk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return battery_type;
            }
        }

        public override string ToString()
        {
            return "Battery Characteristics\n" + "model: " + model + "\nhours_idle: " + hours_idle + "\nhours_talk: " + hours_talk + "\nBattery type: " + battery_type + "\n";
        }
    }
}