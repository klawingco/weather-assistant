using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_Assistant.Util
{
    // Generally we want this to be stored in a persisted data to be more dynamic.
    // For sake of demo, we will just declare this at a enum
    public enum EnumQuestionType
    {
        IsNotRaining =  1,
        WearSunscreen,
        OverWindPressure,
    }
}
