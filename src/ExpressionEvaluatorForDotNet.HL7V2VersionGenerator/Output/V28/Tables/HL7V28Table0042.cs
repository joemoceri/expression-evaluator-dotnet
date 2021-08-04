using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0042
    {
        public string Id { get { return @"0042"; } }

        public string TableId { get { return @"0042"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Company Plan Code"; } }

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
                return null;
            } 
        }
    }
}