using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0338
    {
        public string Id { get { return @"0338"; } }

        public string TableId { get { return @"0338"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Practitioner ID number type"; } }

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
                            Value = @"CY",
                            Description = @"County number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEA",
                            Description = @"Drug Enforcement Agency no.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GL",
                            Description = @"General ledger number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L&I",
                            Description = @"Labor and industries number",
                            Comment = @"Deprecated as of v 2.5; Use LI instead"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Labor and industries number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCD",
                            Description = @"Medicaid number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCR",
                            Description = @"Medicare number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QA",
                            Description = @"QA number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SL",
                            Description = @"State license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TAX",
                            Description = @"Tax ID number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRL",
                            Description = @"Training license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPIN",
                            Description = @"Unique physician ID no.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
