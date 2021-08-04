using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0388
    {
        public string Id { get { return @"0388"; } }

        public string TableId { get { return @"0388"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Processing type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return null;
            } 
        }
    }
}