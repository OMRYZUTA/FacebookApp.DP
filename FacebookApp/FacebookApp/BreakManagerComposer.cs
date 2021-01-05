using System;

namespace FacebookApp
{
    public class BreakManagerComposer
    {
        private IBreakManagerBuilder m_Builder;
        
        public BreaksManager Construct(string i_TimeUnitSelection, int i_UnitNumber)
        {
            if(i_TimeUnitSelection == "Hours")
            {
                m_Builder = new BreakManagerBuilderByHours();
            }
            else
            {
                m_Builder = new BreakManagerBuilderByMinutes();
            }

            m_Builder.m_breakTime = i_UnitNumber;
            BreaksManager o_NewBreaksManager = m_Builder.GetResults();

            return o_NewBreaksManager;
        }
    }
}
