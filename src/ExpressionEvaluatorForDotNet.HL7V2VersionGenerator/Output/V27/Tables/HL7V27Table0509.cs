using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0509
    {
        public string Id { get { return @"0509"; } }

        public string TableId { get { return @"0509"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Indication for Use"; } }

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
                return null;
            } 
        }
    }
}
