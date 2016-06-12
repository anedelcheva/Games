using System;

namespace DefineClass
{
    class GSMTest
    {
        private GSM[] gsms = { new GSM("Galaxy S7 active", "Samsung"), new GSM("Galaxy J5", "Samsung"), new GSM("IPhone 6s", "Apple") };

        public void displayGSMs()
        {
            foreach (var gsm in gsms)
            {
                gsm.displayGSM();
            }
        }

        public static void getInfoForIphone()
        {
            GSM.displayIphone4S();
        }

    }
}