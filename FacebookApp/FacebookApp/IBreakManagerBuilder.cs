using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public interface IBreakManagerBuilder
    {
        int m_breakTime { get; set; }
        BreaksManager GetResults();
    }
}
