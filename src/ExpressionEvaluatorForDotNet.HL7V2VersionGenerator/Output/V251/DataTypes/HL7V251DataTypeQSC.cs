using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataType
    {
        public string Id { get { return @"QSC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Query Selection Criteria"; } }

        public string Description { get { return @"This field indicates the conditions that qualify the rows to be returned in the query response. Note that this field conveys the same information as the ""WHERE"" clause in the corresponding SQL expression of the query, but is formatted differently.

Example: |@PID.5.1^EQ^EVANS| "; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 219; } }

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
                            Id = @"QSC.1",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the field that is participating as a qualifier (usually the ""key""). Refer to Section 2.A.59.1,  Segment Field Name (ST) , for segment field name conventions.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QSC.2",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.2",
                            Name = @"Relational Operator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0209",
                            TableName = @"Relational operator",
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QSC.3",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.3",
                            Name = @"Value",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The value to which the field will be compared.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QSC.4",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.4",
                            Name = @"Relational Conjunction",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0210",
                            TableName = @"Relational conjunction",
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}