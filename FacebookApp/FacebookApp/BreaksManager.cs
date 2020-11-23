namespace FacebookApp
{
    public class BreaksManager
    {
        public eTime breakTime { get; private set; }
        const string k_NoBreaks = "noBreakes";
        const string k_FiveMinutes = "fiveMinutes";
        const string k_TenMinutes = "tenMinutes";
        const string k_FifteenMinutes = "fifteenMinutes";
        const string k_OneHour = "oneHour";

        


        public enum eTime
        {
            noBreakes,
            fiveMinutes,
            tenMinutes,
            fifteenMinutes,
            oneHour
        }

    }
}