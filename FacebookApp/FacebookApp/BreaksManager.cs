
namespace FacebookApp
{
    public class BreaksManager
    {
        public TimeEnum.eTime m_breakTime { get; private set; }
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
            m_breakTime = TimeEnum.eTime.fifteenMinutes;
            m_Stopper = CalculateTime("fifteenMinutesButton");
            m_Seconds = 0;
            m_Minutes = 0;
        }
        
        public void ConvertStringToETime(string i_BreakTime)
        {
            switch(i_BreakTime)
            {
                case k_NoBreaks:
                    m_breakTime = TimeEnum.eTime.noBreakes;
                    break;
                case k_FifteenMinutes:
                    m_breakTime = TimeEnum.eTime.fifteenMinutes;
                    break;
                case k_FiveMinutes:
                    m_breakTime = TimeEnum.eTime.fiveMinutes;
                    break;
                case k_OneHour:
                    m_breakTime = TimeEnum.eTime.oneHour;
                    break;
                case k_TenMinutes:
                    m_breakTime = TimeEnum.eTime.tenMinutes;
                    break;
            }
        }

        public int CalculateTime(string i_ChosenButtonName)
        {
            ConvertStringToETime(i_ChosenButtonName);
            int chosenInterval;
            chosenInterval = ConvertETimeToInt(m_breakTime);
            return chosenInterval;
        }

        private int ConvertETimeToInt(TimeEnum.eTime i_TimeToConvert)
        {
            int minutes = 15; //Chosen Default

            switch (i_TimeToConvert)
            {
                case TimeEnum.eTime.noBreakes:
                    minutes = 0;
                    break;
                case TimeEnum.eTime.fifteenMinutes:
                    minutes = 15;
                    break;
                case TimeEnum.eTime.fiveMinutes:
                    minutes = 5;
                    break;
                case TimeEnum.eTime.oneHour:
                    minutes = 60;
                    break;
                case TimeEnum.eTime.tenMinutes:
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