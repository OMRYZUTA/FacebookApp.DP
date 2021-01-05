namespace FacebookApp
{
    public class BreaksManager
    {
        public int m_breakTime { get; set; }
        public int m_Seconds { get; set; }
        public int m_Minutes { get;  set; }

        public BreaksManager(int i_BreakTimeInMinutes)
        {
            m_breakTime = i_BreakTimeInMinutes; // eTime.fifteenMinutes
            m_Seconds = 0;
            m_Minutes = 0;
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