using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0186
    {
        public string Id { get { return @"0186"; } }

        public string TableId { get { return @"0186"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Practitioner Category"; } }

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
                return null;
            } 
        }
    }
}