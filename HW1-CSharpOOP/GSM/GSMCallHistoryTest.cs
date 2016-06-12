using System;

namespace DefineClass
{
    class GSMCallHistoryTest
    {
        private GSM gsm = new GSM("Galaxy Pocket",
                "Samsung",
                120.32,
                "Lili",
                new Battery("Non-removable 336", 100, 7, BatteryType.NiCd),
                new Display(2.5, 16777216)
                );
        private double price = 0.37;

        Call call1 = new Call(DateTime.Now, "02/8361544", 300);
        Call call2 = new Call(DateTime.Today, "0873445673", 600);

        public void testMethods()
        {
            gsm.addCallToCallHistory(call1);
            gsm.addCallToCallHistory(call2);
            gsm.displayCallHistory();
            Console.WriteLine("Price before removing longest call: " + gsm.calculateCallPriceInCallHistory(price));
            gsm.removeLongestCall();
            Console.WriteLine("Price without longest call: " + gsm.calculateCallPriceInCallHistory(price));
            gsm.clearCallHistory();
            gsm.displayCallHistory();
        }
    }
}