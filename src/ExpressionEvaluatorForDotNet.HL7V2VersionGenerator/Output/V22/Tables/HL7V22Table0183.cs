using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0183
    {
        public string Id { get { return @"0183"; } }

        public string TableId { get { return @"0183"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ACTIVE/INACTIVE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"A",
                            Description = @"Active staff",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Inactive staff",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
