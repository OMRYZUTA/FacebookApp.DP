using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public class BreakManagerComposer
    {
        public IBreakManagerBuilder m_Builder;

        public BreakManagerComposer(IBreakManagerBuilder i_Builder)
        {
            m_Builder = i_Builder;
        }

        public void Construct(string i_timeUnitSelection, int i_UnitNumber)
        {
            if(i_timeUnitSelection == "Hours" && i_UnitNumber > 72)
            {
                Exception tooMuchMinutes = 
                    new Exception("Can't selcet more than 3 days, please select less hours");
                throw tooMuchMinutes;
            }
            else 
            {
                if (i_timeUnitSelection == "Hours")
                {
                    m_Builder.m_breakTime = i_UnitNumber * 60;
                }
                else
                {
                    m_Builder.m_breakTime = i_UnitNumber;
                }
            }
        }
    }
}
