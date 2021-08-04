using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0334
    {
        public string Id { get { return @"0334"; } }

        public string TableId { get { return @"0334"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Disabled person"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"AP",
                            Description = @"Associated party",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GT",
                            Description = @"Guarantor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Insured",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Patient",
                            Comment = null
                        },
                    };
            } 
        }
    }
}