namespace FacebookApp
{
    public interface IBreakManagerBuilder
    {
        int m_BreakTime { set; }

        BreaksManager GetResults();
    }
}
