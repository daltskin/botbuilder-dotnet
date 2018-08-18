﻿using System;
using System.Collections.Generic;
using System.Text;
using DialogFoundation.Backend.LG;

namespace Microsoft.Bot.Builder.Ai.LanguageGeneration.Engine
{
    internal interface ICompositeRequest
    {
        IDictionary<string, LGRequest> Requests { get; set; }
    }
}
