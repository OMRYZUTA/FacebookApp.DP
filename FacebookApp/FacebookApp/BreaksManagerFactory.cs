using System;

namespace FacebookApp
{
    static class BreaksManagerFactory
    {
        static public IBreaksManager CreateBreaksManager(string i_TimeUnitSelection, int i_UnitNumber)
        {

            IBreaksManager o_NewBreaksManager;

            if(i_TimeUnitSelection == "Hours")
            {
                o_NewBreaksManager = new BreaksManagerByHours();
            }
            else if(i_TimeUnitSelection == "Days")
            {
                o_NewBreaksManager = new BreaksManagerByDays();
            }
            else
            {
                o_NewBreaksManager = new BreaksManagerByMinutes();
            }

            o_NewBreaksManager.CreateBreaksManager(i_UnitNumber);

            return o_NewBreaksManager;
        }
    }
}
