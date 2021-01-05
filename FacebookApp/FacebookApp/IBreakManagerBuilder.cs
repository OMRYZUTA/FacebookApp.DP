namespace FacebookApp
{
    public interface IBreakManagerBuilder
    {
        int m_breakTime { set; }

        BreaksManager GetResults();
    }
}
