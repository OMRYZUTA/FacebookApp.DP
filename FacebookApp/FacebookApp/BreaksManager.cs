namespace FacebookApp
{
    public class BreaksManager
    {
        public int BreakTime { get; }

        public int Seconds { get; set; }

        public int Minutes { get; set; }

        public BreaksManager(int i_BreakTimeInMinutes)
        {
            BreakTime = i_BreakTimeInMinutes; // eTime.fifteenMinutes
            Seconds = 0;
            Minutes = 0;
        }

        public void InitMinutes()
        {
            Minutes = 0;
        }

        public void InitSeconds()
        {
            Seconds = 0;
        }
    }
}