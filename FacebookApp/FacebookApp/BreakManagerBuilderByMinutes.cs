namespace FacebookApp
{
    public class BreakManagerBuilderByMinutes : IBreakManagerBuilder
    {
        public int m_BreakTime { get; set; }

        public BreaksManager GetResults()
        {
            return new BreaksManager(m_BreakTime);
        }
    }
}
