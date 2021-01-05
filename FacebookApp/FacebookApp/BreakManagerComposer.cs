using System;

namespace FacebookApp
{
    public class BreakManagerComposer
    {
        private readonly IBreakManagerBuilder r_Builder;

        public BreakManagerComposer(IBreakManagerBuilder i_Builder)
        {
            r_Builder = i_Builder;
        }

        public void Construct(string i_TimeUnitSelection, int i_UnitNumber)
        {
            if(i_TimeUnitSelection == "Hours" && i_UnitNumber > 72)
            {
                Exception tooMuchMinutes = 
                    new Exception("Can't selcet more than 3 days, please select less hours");
                throw tooMuchMinutes;
            }
            else 
            {
                if (i_TimeUnitSelection == "Hours")
                {
                    r_Builder.m_breakTime = i_UnitNumber * 60;
                }
                else
                {
                    r_Builder.m_breakTime = i_UnitNumber;
                }
            }
        }
    }
}
