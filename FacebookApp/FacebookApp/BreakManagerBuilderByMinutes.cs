using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    class BreakManagerBuilderByMinutes : IBreakManagerBuilder
    {
        public int m_breakTime { get; set; }

        public BreaksManager GetResults()
        {
            return new BreaksManager(m_breakTime);
        }
    }
}
