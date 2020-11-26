
namespace FacebookApp
{
    public class BreaksManager
    {
        private eTime m_breakTime { get; set; }
        public int m_Stopper { get; set; }
        public int m_Seconds { get; set; }
        public int m_Minutes { get; set; }
        const string k_NoBreaks = "noBreaksButton";
        const string k_FiveMinutes = "fiveMinutesButton";
        const string k_TenMinutes = "tenMinutesButton";
        const string k_FifteenMinutes = "fifteenMinutesButton";
        const string k_OneHour = "oneHourButton";

        public BreaksManager()
        {
            m_breakTime = eTime.fifteenMinutes;
            m_Stopper = CalculateTime("fifteenMinutesButton");
            m_Seconds = 0;
            m_Minutes = 0;
        }

        private void ConvertStringToETime(string i_BreakTime)
        {
            switch(i_BreakTime)
            {
                case k_NoBreaks:
                    m_breakTime = eTime.noBreakes;
                    break;
                case k_FifteenMinutes:
                    m_breakTime = eTime.fifteenMinutes;
                    break;
                case k_FiveMinutes:
                    m_breakTime = eTime.fiveMinutes;
                    break;
                case k_OneHour:
                    m_breakTime = eTime.oneHour;
                    break;
                case k_TenMinutes:
                    m_breakTime = eTime.tenMinutes;
                    break;
            }
        }

        public int CalculateTime(string i_ChosenButtonName)
        {
            ConvertStringToETime(i_ChosenButtonName);
            int chosenInterval = this.ConvertETimeToInt(this.m_breakTime);
            return chosenInterval;
        }

        private int ConvertETimeToInt(eTime i_TimeToConvert)
        {
            int minutes = 15; //Chosen Default

            switch (i_TimeToConvert)
            {
                case eTime.noBreakes:
                    minutes = 0;
                    break;
                case eTime.fifteenMinutes:
                    minutes = 15;
                    break;
                case eTime.fiveMinutes:
                    minutes = 5;
                    break;
                case eTime.oneHour:
                    minutes = 60;
                    break;
                case eTime.tenMinutes:
                    minutes = 10;
                    break;
            }

            return minutes;
        }



        public void InitMinutes()
        {
            m_Minutes = 0;
        }

        public void InitSeconds()
        {
            m_Seconds = 0;
        }
    }
}