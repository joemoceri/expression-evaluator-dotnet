using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0395
    {
        public string Id { get { return @"0395"; } }

        public string TableId { get { return @"0395"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Modify Indicator"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Modified Subscription",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"New Subscription",
                            Comment = null
                        },
                    };
            } 
        }
    }
}