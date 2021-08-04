using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0246
    {
        public string Id { get { return @"0246"; } }

        public string TableId { get { return @"0246"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Product available for inspection"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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