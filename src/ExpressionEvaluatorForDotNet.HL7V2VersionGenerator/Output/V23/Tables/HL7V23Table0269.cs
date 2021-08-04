using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0269
    {
        public string Id { get { return @"0269"; } }

        public string TableId { get { return @"0269"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Charge on indicator"; } }

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
                            Value = @"O",
                            Description = @"Charge on Order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Charge on Result",
                            Comment = null
                        },
                    };
            } 
        }
    }
}