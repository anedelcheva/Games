using System;
using System.Collections.Generic;

namespace DefineClass
{
    internal class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private static readonly GSM iphone4S =
            new GSM("iPhone 4s",
                "Apple",
                449.99,
                "Lili",
                new Battery("Non-removable 1432", 200, 14, BatteryType.Li_Po),
                new Display(3.5, 16777216)
                );

        private List<Call> call_history = new List<Call>();

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0.0, null, null, null)
        {

        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer, price, null, null, null)
        {

        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {

        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {

        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                if (model == null)
                {
                    throw new ArgumentNullException("Model cannot be null");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                if (manufacturer == null)
                {
                    throw new ArgumentNullException("Manufacturer cannot be null");
                }
                manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Price cannot be less than 0");
                }
                price = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                if (owner == null)
                {
                    throw new ArgumentNullException("Owner cannot be null");
                }
                owner = value;
            }
        }

        public GSM Iphone4S
        {
            get
            {
                return iphone4S;
            }
        }
        public override string ToString()
        {
            return "model: " + model + "\nmanufacturer: " + manufacturer + "\nprice: " + price + "\nowner: " + owner + "\n";
        }

        public void displayGSM()
        {
            Console.WriteLine(ToString());
        }

        public static void displayIphone4S()
        {
            Console.WriteLine(iphone4S.ToString());
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.call_history;
            }
        }

        public void displayCallHistory()
        {
            foreach (var call in call_history)
            {
                Console.WriteLine(call.ToString());
            }
        }

        public void addCallToCallHistory(Call call)
        {
            call_history.Add(call);
        }

        public void deleteCallFromCallHistory(Call call)
        {
            if (!this.call_history.Contains(call))
            {
                throw new Exception("Call not found in call history");
            }

            this.call_history.Remove(call);
        }

        public void clearCallHistory()
        {
            this.call_history.Clear();
        }

        public void removeLongestCall()
        {
            uint max = uint.MinValue;
            Call longest_call = null;
            foreach (Call call in call_history)
            {
                if (max < call.DurationInSeconds)
                {
                    max = call.DurationInSeconds;
                    longest_call = call;
                }
            }
            call_history.Remove(longest_call);
        }

        public double calculateCallPriceInCallHistory(double price)
        {
            double total = 0;
            foreach (var call in call_history)
            {
                total += call.calculateCallPrice(price);
            }
            return total;
        }


    }
}