using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0137
    {
        public string Id { get { return @"0137"; } }

        public string TableId { get { return @"0137"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Mail claim party"; } }

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
                            Value = @"E",
                            Description = @"Employer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"G",
                            Description = @"Guarantor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Insurance company",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Patient",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
