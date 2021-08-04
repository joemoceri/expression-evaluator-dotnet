using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0238
    {
        public string Id { get { return @"0238"; } }

        public string TableId { get { return @"0238"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Event Seriousness"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Value = @"N",
                            Description = @"No",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Significant",
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