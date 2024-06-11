using System;
using System.ComponentModel;

namespace Swim_Time_Converter.Constants
{    
    public enum EventTypes
    {
        [Description("50 Freestyle")]
        FREE50,
        [Description("100 Freestyle")]
        FREE100,
        [Description("200 Freestyle")]
        FREE200,
        [Description("50 Butterfly")]
        FLY50,
        [Description("100 Butterfly")]
        FLY100,
        [Description("200 Butterfly")]
        FLY200,
        [Description("50 Breaststroke")]
        BREAST50,
        [Description("100 Breaststroke")]
        BREAST100,
        [Description("200 Breaststroke")]
        BREAST200,
        [Description("50 Backstroke")]
        BACK50,
        [Description("100 Backstroke")]
        BACK100,
        [Description("200 Backstroke")]
        BACK200,
        [Description("200 Individual Medley")]
        IM200,
        [Description("200 Individual Medley")]
        IM400,
        [Description("400/500 Freestyle")]
        FREE400_500,
        [Description("800/100 Freestyle")]
        FREE800_1000,
        [Description("1500/1650 Freestyle")]
        FREE1500_1650,
    }
}
