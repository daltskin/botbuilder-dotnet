﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Bot.Builder.Ai.LanguageGeneration.Engine
{
    internal enum SlotTypeEnum
    {
        StringType = 0,
        IntType = 1,
        FloatType = 2,
        BooleanType = 3,
        DateTimeType = 4,
    }

    internal class Slot
    {
        public KeyValuePair<string, object> KeyValue { get; set; }
        public SlotTypeEnum Type
        {
            get
            {
                if (KeyValue.Equals(null))
                {
                    throw new ArgumentNullException(nameof(KeyValue));
                }

                if (KeyValue.Value is IList<string>)
                {
                    return SlotTypeEnum.StringType;
                }

                if (KeyValue.Value is IList<int>)
                {
                    return SlotTypeEnum.IntType;
                }

                if (KeyValue.Value is IList<float>)
                {
                    return SlotTypeEnum.FloatType;
                }

                if (KeyValue.Value is IList<bool>)
                {
                    return SlotTypeEnum.BooleanType;
                }

                if (KeyValue.Value is IList<DateTime>)
                {
                    return SlotTypeEnum.DateTimeType;
                }

                else
                {
                    throw new ArgumentException("Unknown slot type");
                }
            }
        }
    }
}
