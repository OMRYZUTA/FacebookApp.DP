
namespace FacebookApp
{
    public class BreaksManager
    {
        public eTime m_breakTime { get; private set; }
        public int m_Stopper { get; set; }
        public int m_Seconds { get; set; }
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
        }
        
        public void ConvertStringToETime(string i_BreakTime)
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
            int chosenInterval;

            chosenInterval = ConvertETimeToInt(m_breakTime) * 60 * 1000;

            return chosenInterval;
        }

        private int ConvertETimeToInt(eTime i_TimeToConvert)
        {
            int i_Minutes = 15; //Chosen Default

            switch (i_TimeToConvert)
            {
                case eTime.noBreakes:
                    i_Minutes = 0;
                    break;
                case eTime.fifteenMinutes:
                    i_Minutes = 15;
                    break;
                case eTime.fiveMinutes:
                    i_Minutes = 5;
                    break;
                case eTime.oneHour:
                    i_Minutes = 60;
                    break;
                case eTime.tenMinutes:
                    i_Minutes = 10;
                    break;
            }

            return i_Minutes;
        }


        public enum eTime
        {
            noBreakes,
            fiveMinutes,
            tenMinutes,
            fifteenMinutes,
            oneHour
        }

        public void InitSeconds()
        {
            m_Seconds = 0;
        }
    }
}