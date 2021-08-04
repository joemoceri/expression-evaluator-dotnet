using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21DataType
    {
        public string Id { get { return @"CK"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite Id With Check Digit"; } }

        public string Description { get { return null; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return null;
            }
        }
    }
}