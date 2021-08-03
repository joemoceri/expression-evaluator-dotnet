using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0555
    {
        public string Id { get { return @"0555"; } }

        public string TableId { get { return @"0555"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Invoice Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"BK",
                            Description = @"Block",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FN",
                            Description = @"Final",
                            Comment = @"Final Invoice"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FS",
                            Description = @"Fee for Service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GP",
                            Description = @"Group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Information Only",
                            Comment = @"Payee information not required for this Invoice Type"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"Non Patient",
                            Comment = @"Invoice without a patient.  E.g. bulk invoicing for Pharmacy for a care facility."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Partial",
                            Comment = @"Partial Invoice"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SL",
                            Description = @"Salary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"By Session",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Supplemental",
                            Comment = @"Supplemental Invoice"
                        },
                    };
            } 
        }
    }
}
