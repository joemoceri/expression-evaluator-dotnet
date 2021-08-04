﻿namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Field
    {
        public readonly HL7V2Field field;
        public readonly HL7V2FieldData fieldData;

        public HL7V23Field(HL7V2Field field, HL7V2FieldData fieldData)
        {
            this.field = field;
            this.fieldData = fieldData;
        }

        public string Value { get { return field.Value; } }
    }
}