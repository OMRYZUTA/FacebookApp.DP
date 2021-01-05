namespace FacebookApp
{
    public class BreakManagerBuilderByHours : IBreakManagerBuilder
    {
        public int m_breakTime { get; set; }

        public BreaksManager GetResults()
        {
            return new BreaksManager(m_breakTime * 60);
        }
    }
}
