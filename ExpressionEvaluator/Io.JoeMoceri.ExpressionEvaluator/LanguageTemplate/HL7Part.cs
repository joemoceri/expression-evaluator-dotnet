﻿namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7Part
    {
        public string Segment { get; set; }

        public int DelimiterIndex { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }
    }
}