using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0073
    {
        public string Id { get { return @"0073"; } }

        public string TableId { get { return @"0073"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Interest rate code"; } }

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
                return null;
            } 
        }
    }
}