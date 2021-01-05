namespace FacebookApp
{
    public interface IBreakManagerBuilder
    {
        int BreakTime { set; }

        BreaksManager GetResults();
    }
}
