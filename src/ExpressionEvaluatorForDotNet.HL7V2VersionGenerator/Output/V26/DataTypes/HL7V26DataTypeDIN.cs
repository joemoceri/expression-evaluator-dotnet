using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"DIN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date and Institution Name"; } }

        public string Description { get { return @"Specifies the date and institution information where a staff member became active or inactive."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 730; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DIN.1",
                            Type = @"DataTypeComponent",
                            Position = @"DIN.1",
                            Name = @"Date",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date when a staff member became active or inactive.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DIN.2",
                            Type = @"DataTypeComponent",
                            Position = @"DIN.2",
                            Name = @"Institution Name",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0531",
                            TableName = @"Institution",
                            Description = @"Specifies the institution where a staff member is or was active. Refer to User-Defined Table 0531 - Institutions for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}