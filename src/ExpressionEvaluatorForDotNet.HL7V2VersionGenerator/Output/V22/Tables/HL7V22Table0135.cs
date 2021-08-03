using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0135
    {
        public string Id { get { return @"0135"; } }

        public string TableId { get { return @"0135"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"ASSIGNMENT OF BENEFITS"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Description = @"Modified assignment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"No",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"Yes",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
