namespace FacebookApp
{
    public class BreakManagerBuilderByHours : IBreakManagerBuilder
    {
        public int BreakTime { get; set; }

        public BreaksManager GetResults()
        {
            return new BreaksManager(BreakTime * 60);
        }
    }
}
