namespace FacebookApp
{
    public interface IBreaksManager
    {
         int m_BreakTime { get; set; }
         int m_Seconds { get; set; }
         int m_Minutes { get; set; }

         void CreateBreaksManager(int i_BreakTimeInMinutes);

         void InitBreakTime(int i_BreakTimeInMinutes);

         void InitMinutes();

         void InitSeconds();
    }
}