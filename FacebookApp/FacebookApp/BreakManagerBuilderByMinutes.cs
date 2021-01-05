namespace FacebookApp
{
    public class BreakManagerBuilderByMinutes : IBreakManagerBuilder
    {
        public int BreakTime { get; set; }

        public BreaksManager GetResults()
        {
            return new BreaksManager(BreakTime);
        }
    }
}
