namespace FacebookApp
{
    public class BreakManagerBuilderByHours : IBreakManagerBuilder
    {
        public int m_BreakTime { get; set; }

        public BreaksManager GetResults()
        {
            return new BreaksManager(m_BreakTime * 60);
        }
    }
}
