namespace FacebookApp
{
    public class BreakManagerBuilderByMinutes : IBreakManagerBuilder
    {
        public int m_breakTime { get; set; }

        public BreaksManager GetResults()
        {
            return new BreaksManager(m_breakTime);
        }
    }
}
