using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentPEO
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PEO"; } }

        public string SegmentId { get { return @"PEO"; } }
        
        public string LongName { get { return @"Product experience observation segment"; } }
        
        public string Description { get { return @"Details related to a particular clinical experience or event are embodied in the PEO segment. This segment can be used to characterize an event which might be attributed to a product to which the patient was exposed. Products with a possible causal relationship to the observed experience are described in the following PCR (possible causal relationship) segments. The message format was designed to be robust and includes many optional elements which may not be required for a particular regulatory purpose but allow a complete representation of the drug experience if needed."; } }
        
        public string Sample { get { return @""; } }

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PEO.1",
                            Type = @"Field",
                            Position = @"PEO.1",
                            Name = @"Event Identifiers Used",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be used to transmit the event identifier used by other entities for this event. The entry would typically contain a unique alphanumeric identifier assigned by an entity with the text component null or repeating the unique alphanumeric identifier followed by the organization's identifier. An event identifier might be GB1234^GB1234^PharmaGiant for example.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.1",
                            Type = @"Component",
                            Position = @"PEO.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.2",
                            Type = @"Component",
                            Position = @"PEO.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.3",
                            Type = @"Component",
                            Position = @"PEO.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.4",
                            Type = @"Component",
                            Position = @"PEO.1.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.5",
                            Type = @"Component",
                            Position = @"PEO.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.1.6",
                            Type = @"Component",
                            Position = @"PEO.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2",
                            Type = @"Field",
                            Position = @"PEO.2",
                            Name = @"Event Symptom/Diagnosis Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the coded diagnosis or problem description which best describes the event. A text representation of the coded item should routinely be included. MEDDRA and WHO-ART are examples of appropriate coding schemes, as are the patient and device codes included in the FDA Center for Devices and Radiologic Health's coding manual for Form 3500A.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.1",
                            Type = @"Component",
                            Position = @"PEO.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.2",
                            Type = @"Component",
                            Position = @"PEO.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.3",
                            Type = @"Component",
                            Position = @"PEO.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.4",
                            Type = @"Component",
                            Position = @"PEO.2.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.5",
                            Type = @"Component",
                            Position = @"PEO.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.2.6",
                            Type = @"Component",
                            Position = @"PEO.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.3",
                            Type = @"Field",
                            Position = @"PEO.3",
                            Name = @"Event Onset Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a report or best estimate of the date/time of onset of the event. The date/time can be recorded to any level of precision it is known (hour, day, month, year).",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.3.1",
                            Type = @"Component",
                            Position = @"PEO.3.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.4",
                            Type = @"Field",
                            Position = @"PEO.4",
                            Name = @"Event Exacerbation Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the best estimate of the date/time the event was exacerbated.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.4.1",
                            Type = @"Component",
                            Position = @"PEO.4.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.5",
                            Type = @"Field",
                            Position = @"PEO.5",
                            Name = @"Event Improved Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the best estimate of the date/time the event improved.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.5.1",
                            Type = @"Component",
                            Position = @"PEO.5.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.6",
                            Type = @"Field",
                            Position = @"PEO.6",
                            Name = @"Event Ended Data/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the best estimate of the date/time the event resolved.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.6.1",
                            Type = @"Component",
                            Position = @"PEO.6.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7",
                            Type = @"Field",
                            Position = @"PEO.7",
                            Name = @"Event Location Occurred Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the location at which the event started. Often this will specify only the country in which the event started.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.1",
                            Type = @"Component",
                            Position = @"PEO.7.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.2",
                            Type = @"Component",
                            Position = @"PEO.7.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.3",
                            Type = @"Component",
                            Position = @"PEO.7.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.4",
                            Type = @"Component",
                            Position = @"PEO.7.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.5",
                            Type = @"Component",
                            Position = @"PEO.7.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.6",
                            Type = @"Component",
                            Position = @"PEO.7.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.7",
                            Type = @"Component",
                            Position = @"PEO.7.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.8",
                            Type = @"Component",
                            Position = @"PEO.7.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.9",
                            Type = @"Component",
                            Position = @"PEO.7.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County code",
                            Description = @"A code that represents the county in which the specified address resides. User-defined table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.10",
                            Type = @"Component",
                            Position = @"PEO.7.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.7.11",
                            Type = @"Component",
                            Position = @"PEO.7.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.8",
                            Type = @"Field",
                            Position = @"PEO.8",
                            Name = @"Event Qualification",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0237",
                            TableName = @"Event qualification",
                            Description = @"This field is contains a classification of the type of product experience this event is considered to represent. Refer to HL7 table 0237 - Event qualification for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.9",
                            Type = @"Field",
                            Position = @"PEO.9",
                            Name = @"Event Serious",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0238",
                            TableName = @"Event seriousness",
                            Description = @"This field indicates whether the event was judged as serious. If the event did not meet the criteria for seriousness but the sender judges the event significant on other grounds, the event can be identified as significant [but not serious]. Refer to HL7 table 0238 - Event seriousness for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.10",
                            Type = @"Field",
                            Position = @"PEO.10",
                            Name = @"Event Expected",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0239",
                            TableName = @"Event expected",
                            Description = @"This field indicates whether the observed event was expected or unexpected as judged. Refer to HL7 table 0239 - Event expected for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.11",
                            Type = @"Field",
                            Position = @"PEO.11",
                            Name = @"Event Outcome",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0240",
                            TableName = @"Event consequence",
                            Description = @"This field identifies the consequence of the event on the patient. If the consequence of the event is not understood or not available, the patient outcome element may be used although neither is required. May be repeated if more than one is appropriate. Refer to HL7 table 0240 - Event consequence for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.12",
                            Type = @"Field",
                            Position = @"PEO.12",
                            Name = @"Patient Outcome",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0241",
                            TableName = @"Patient outcome",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.13",
                            Type = @"Field",
                            Position = @"PEO.13",
                            Name = @"Event Description From Others",
                            Length = 600,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a summary narrative text description of the event that occurred written by the sender. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative. By representing clinical information in OBX segments rather than in the narrative, these data become much more useful and flexible.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.14",
                            Type = @"Field",
                            Position = @"PEO.14",
                            Name = @"Event From Original Reporter",
                            Length = 600,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a summary narrative text description of the event provided by the original reporter. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.15",
                            Type = @"Field",
                            Position = @"PEO.15",
                            Name = @"Event Description From Patient",
                            Length = 600,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a summary narrative text description of the event obtained directly from the patient. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative, which will allow the data to be more readily represented and manipulated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.16",
                            Type = @"Field",
                            Position = @"PEO.16",
                            Name = @"Event Description From Practitioner",
                            Length = 600,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a summary narrative text description of the event provided by the practitioner most familiar with the event. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.17",
                            Type = @"Field",
                            Position = @"PEO.17",
                            Name = @"Event Description From Autopsy",
                            Length = 600,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a summary narrative text description of the autopsy results. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18",
                            Type = @"Field",
                            Position = @"PEO.18",
                            Name = @"Cause Of Death",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the coded cause of death. May be repeated as necessary to list multiple contributing causes. A text description can be included by including text but no code or coding system. For example, if the cause of death is to be determined at autopsy but results are not yet available, the cause of death element could be ^Pending autopsy^. The date/time of death can be sent in the PID and the autopsy results sent in the event description from autopsy element of the PEO segment.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.1",
                            Type = @"Component",
                            Position = @"PEO.18.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.2",
                            Type = @"Component",
                            Position = @"PEO.18.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.3",
                            Type = @"Component",
                            Position = @"PEO.18.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.4",
                            Type = @"Component",
                            Position = @"PEO.18.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.5",
                            Type = @"Component",
                            Position = @"PEO.18.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.18.6",
                            Type = @"Component",
                            Position = @"PEO.18.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19",
                            Type = @"Field",
                            Position = @"PEO.19",
                            Name = @"Primary Observer Name",
                            Length = 46,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the name of the person who initially described the event.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.1",
                            Type = @"Component",
                            Position = @"PEO.19.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.1.1",
                            Type = @"SubComponent",
                            Position = @"PEO.19.1.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.1.2",
                            Type = @"SubComponent",
                            Position = @"PEO.19.1.2",
                            Name = @"Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.2",
                            Type = @"Component",
                            Position = @"PEO.19.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.3",
                            Type = @"Component",
                            Position = @"PEO.19.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.4",
                            Type = @"Component",
                            Position = @"PEO.19.4",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.5",
                            Type = @"Component",
                            Position = @"PEO.19.5",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.6",
                            Type = @"Component",
                            Position = @"PEO.19.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.7",
                            Type = @"Component",
                            Position = @"PEO.19.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.19.8",
                            Type = @"Component",
                            Position = @"PEO.19.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20",
                            Type = @"Field",
                            Position = @"PEO.20",
                            Name = @"Primary Observer Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the address of the person who initially described the event.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.1",
                            Type = @"Component",
                            Position = @"PEO.20.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.2",
                            Type = @"Component",
                            Position = @"PEO.20.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.3",
                            Type = @"Component",
                            Position = @"PEO.20.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.4",
                            Type = @"Component",
                            Position = @"PEO.20.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.5",
                            Type = @"Component",
                            Position = @"PEO.20.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.6",
                            Type = @"Component",
                            Position = @"PEO.20.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.7",
                            Type = @"Component",
                            Position = @"PEO.20.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.8",
                            Type = @"Component",
                            Position = @"PEO.20.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.9",
                            Type = @"Component",
                            Position = @"PEO.20.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County code",
                            Description = @"A code that represents the county in which the specified address resides. User-defined table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.10",
                            Type = @"Component",
                            Position = @"PEO.20.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.20.11",
                            Type = @"Component",
                            Position = @"PEO.20.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21",
                            Type = @"Field",
                            Position = @"PEO.21",
                            Name = @"Primary Observer Telephone",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the telephone number of the person who initially described the event.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.1",
                            Type = @"Component",
                            Position = @"PEO.21.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.2",
                            Type = @"Component",
                            Position = @"PEO.21.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.3",
                            Type = @"Component",
                            Position = @"PEO.21.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.4",
                            Type = @"Component",
                            Position = @"PEO.21.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.5",
                            Type = @"Component",
                            Position = @"PEO.21.5",
                            Name = @"Country Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.6",
                            Type = @"Component",
                            Position = @"PEO.21.6",
                            Name = @"Area/City Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.7",
                            Type = @"Component",
                            Position = @"PEO.21.7",
                            Name = @"Phone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.8",
                            Type = @"Component",
                            Position = @"PEO.21.8",
                            Name = @"Extension",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.21.9",
                            Type = @"Component",
                            Position = @"PEO.21.9",
                            Name = @"Any Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.22",
                            Type = @"Field",
                            Position = @"PEO.22",
                            Name = @"Primary Observer s Qualification",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0242",
                            TableName = @"Primary observer’s qualification",
                            Description = @"This field contains the qualification of the primary observer which may assist in assessing the validity of the observations. Refer to HL7 table 0242 - Primary observer's qualification for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.23",
                            Type = @"Field",
                            Position = @"PEO.23",
                            Name = @"Confirmation Provided By",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0242",
                            TableName = @"Primary observer’s qualification",
                            Description = @"This field contains the qualification of the health professional who confirmed the observation if the primary observer was not a health professional. Refer to HL7 table 0242 - Primary observer'squalification for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.24",
                            Type = @"Field",
                            Position = @"PEO.24",
                            Name = @"Primary Observer Aware Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the date/time the primary observer became aware of event.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PEO.24.1",
                            Type = @"Component",
                            Position = @"PEO.24.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PEO.25",
                            Type = @"Field",
                            Position = @"PEO.25",
                            Name = @"Primary Observer s identity May Be Divulged",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0243",
                            TableName = @"Identity may be divulged",
                            Description = @"Indicates whether or not the primary observer, if known to the sender, grants permission to disclose his or her identity to the product manufacturer for the purpose of further investigating the event. If the element is absent, the assumption should be made that permission is not granted. Refer to HL7 table 0243 - Identity may be divulged for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V231SegmentPEO(HL7V2Message message)
        {
            this.message = message;
        }

        
internal HL7V231Field eventIdentifiersUsed;

public HL7V231Field EventIdentifiersUsed
{
    get
    {
        if (eventIdentifiersUsed != null)
        {
            return eventIdentifiersUsed;
        }

        eventIdentifiersUsed = new HL7V231Field
        {
            field = message[@"PEO"][1],
            Id = @"PEO.1",
            Type = @"Field",
            Position = @"PEO.1",
            Name = @"Event Identifiers Used",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field may be used to transmit the event identifier used by other entities for this event. The entry would typically contain a unique alphanumeric identifier assigned by an entity with the text component null or repeating the unique alphanumeric identifier followed by the organization's identifier. An event identifier might be GB1234^GB1234^PharmaGiant for example.",
            Sample = @"",
        };

        // check for repetitions
        if (eventIdentifiersUsed.field.FieldRepetitions != null && eventIdentifiersUsed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventIdentifiersUsed.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventIdentifiersUsed.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventIdentifiersUsed.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventIdentifiersUsed.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventIdentifiersUsed.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventIdentifiersUsed.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventIdentifiersUsed.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventIdentifiersUsed.fieldRepetitions = fieldRepetitions;
        }

        return eventIdentifiersUsed;
    } 
}

internal HL7V231Field eventSymptomDiagnosisCode;

public HL7V231Field EventSymptomDiagnosisCode
{
    get
    {
        if (eventSymptomDiagnosisCode != null)
        {
            return eventSymptomDiagnosisCode;
        }

        eventSymptomDiagnosisCode = new HL7V231Field
        {
            field = message[@"PEO"][2],
            Id = @"PEO.2",
            Type = @"Field",
            Position = @"PEO.2",
            Name = @"Event Symptom/Diagnosis Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the coded diagnosis or problem description which best describes the event. A text representation of the coded item should routinely be included. MEDDRA and WHO-ART are examples of appropriate coding schemes, as are the patient and device codes included in the FDA Center for Devices and Radiologic Health's coding manual for Form 3500A.",
            Sample = @"",
        };

        // check for repetitions
        if (eventSymptomDiagnosisCode.field.FieldRepetitions != null && eventSymptomDiagnosisCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventSymptomDiagnosisCode.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventSymptomDiagnosisCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventSymptomDiagnosisCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventSymptomDiagnosisCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventSymptomDiagnosisCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventSymptomDiagnosisCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventSymptomDiagnosisCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventSymptomDiagnosisCode.fieldRepetitions = fieldRepetitions;
        }

        return eventSymptomDiagnosisCode;
    } 
}

internal HL7V231Field eventOnsetDateTime;

public HL7V231Field EventOnsetDateTime
{
    get
    {
        if (eventOnsetDateTime != null)
        {
            return eventOnsetDateTime;
        }

        eventOnsetDateTime = new HL7V231Field
        {
            field = message[@"PEO"][3],
            Id = @"PEO.3",
            Type = @"Field",
            Position = @"PEO.3",
            Name = @"Event Onset Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains a report or best estimate of the date/time of onset of the event. The date/time can be recorded to any level of precision it is known (hour, day, month, year).",
            Sample = @"",
        };

        // check for repetitions
        if (eventOnsetDateTime.field.FieldRepetitions != null && eventOnsetDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventOnsetDateTime.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventOnsetDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventOnsetDateTime.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventOnsetDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventOnsetDateTime.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventOnsetDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventOnsetDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventOnsetDateTime.fieldRepetitions = fieldRepetitions;
        }

        return eventOnsetDateTime;
    } 
}

internal HL7V231Field eventExacerbationDateTime;

public HL7V231Field EventExacerbationDateTime
{
    get
    {
        if (eventExacerbationDateTime != null)
        {
            return eventExacerbationDateTime;
        }

        eventExacerbationDateTime = new HL7V231Field
        {
            field = message[@"PEO"][4],
            Id = @"PEO.4",
            Type = @"Field",
            Position = @"PEO.4",
            Name = @"Event Exacerbation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the best estimate of the date/time the event was exacerbated.",
            Sample = @"",
        };

        // check for repetitions
        if (eventExacerbationDateTime.field.FieldRepetitions != null && eventExacerbationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventExacerbationDateTime.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventExacerbationDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventExacerbationDateTime.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventExacerbationDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventExacerbationDateTime.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventExacerbationDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventExacerbationDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventExacerbationDateTime.fieldRepetitions = fieldRepetitions;
        }

        return eventExacerbationDateTime;
    } 
}

internal HL7V231Field eventImprovedDateTime;

public HL7V231Field EventImprovedDateTime
{
    get
    {
        if (eventImprovedDateTime != null)
        {
            return eventImprovedDateTime;
        }

        eventImprovedDateTime = new HL7V231Field
        {
            field = message[@"PEO"][5],
            Id = @"PEO.5",
            Type = @"Field",
            Position = @"PEO.5",
            Name = @"Event Improved Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the best estimate of the date/time the event improved.",
            Sample = @"",
        };

        // check for repetitions
        if (eventImprovedDateTime.field.FieldRepetitions != null && eventImprovedDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventImprovedDateTime.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventImprovedDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventImprovedDateTime.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventImprovedDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventImprovedDateTime.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventImprovedDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventImprovedDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventImprovedDateTime.fieldRepetitions = fieldRepetitions;
        }

        return eventImprovedDateTime;
    } 
}

internal HL7V231Field eventEndedDataTime;

public HL7V231Field EventEndedDataTime
{
    get
    {
        if (eventEndedDataTime != null)
        {
            return eventEndedDataTime;
        }

        eventEndedDataTime = new HL7V231Field
        {
            field = message[@"PEO"][6],
            Id = @"PEO.6",
            Type = @"Field",
            Position = @"PEO.6",
            Name = @"Event Ended Data/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the best estimate of the date/time the event resolved.",
            Sample = @"",
        };

        // check for repetitions
        if (eventEndedDataTime.field.FieldRepetitions != null && eventEndedDataTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventEndedDataTime.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventEndedDataTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventEndedDataTime.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventEndedDataTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventEndedDataTime.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventEndedDataTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventEndedDataTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventEndedDataTime.fieldRepetitions = fieldRepetitions;
        }

        return eventEndedDataTime;
    } 
}

internal HL7V231Field eventLocationOccurredAddress;

public HL7V231Field EventLocationOccurredAddress
{
    get
    {
        if (eventLocationOccurredAddress != null)
        {
            return eventLocationOccurredAddress;
        }

        eventLocationOccurredAddress = new HL7V231Field
        {
            field = message[@"PEO"][7],
            Id = @"PEO.7",
            Type = @"Field",
            Position = @"PEO.7",
            Name = @"Event Location Occurred Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the location at which the event started. Often this will specify only the country in which the event started.",
            Sample = @"",
        };

        // check for repetitions
        if (eventLocationOccurredAddress.field.FieldRepetitions != null && eventLocationOccurredAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventLocationOccurredAddress.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventLocationOccurredAddress.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventLocationOccurredAddress.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventLocationOccurredAddress.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventLocationOccurredAddress.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventLocationOccurredAddress.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventLocationOccurredAddress.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventLocationOccurredAddress.fieldRepetitions = fieldRepetitions;
        }

        return eventLocationOccurredAddress;
    } 
}

internal HL7V231Field eventQualification;

public HL7V231Field EventQualification
{
    get
    {
        if (eventQualification != null)
        {
            return eventQualification;
        }

        eventQualification = new HL7V231Field
        {
            field = message[@"PEO"][8],
            Id = @"PEO.8",
            Type = @"Field",
            Position = @"PEO.8",
            Name = @"Event Qualification",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0237",
            TableName = @"Event qualification",
            Description = @"This field is contains a classification of the type of product experience this event is considered to represent. Refer to HL7 table 0237 - Event qualification for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (eventQualification.field.FieldRepetitions != null && eventQualification.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventQualification.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventQualification.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventQualification.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventQualification.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventQualification.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventQualification.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventQualification.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventQualification.fieldRepetitions = fieldRepetitions;
        }

        return eventQualification;
    } 
}

internal HL7V231Field eventSerious;

public HL7V231Field EventSerious
{
    get
    {
        if (eventSerious != null)
        {
            return eventSerious;
        }

        eventSerious = new HL7V231Field
        {
            field = message[@"PEO"][9],
            Id = @"PEO.9",
            Type = @"Field",
            Position = @"PEO.9",
            Name = @"Event Serious",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0238",
            TableName = @"Event seriousness",
            Description = @"This field indicates whether the event was judged as serious. If the event did not meet the criteria for seriousness but the sender judges the event significant on other grounds, the event can be identified as significant [but not serious]. Refer to HL7 table 0238 - Event seriousness for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (eventSerious.field.FieldRepetitions != null && eventSerious.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventSerious.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventSerious.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventSerious.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventSerious.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventSerious.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventSerious.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventSerious.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventSerious.fieldRepetitions = fieldRepetitions;
        }

        return eventSerious;
    } 
}

internal HL7V231Field eventExpected;

public HL7V231Field EventExpected
{
    get
    {
        if (eventExpected != null)
        {
            return eventExpected;
        }

        eventExpected = new HL7V231Field
        {
            field = message[@"PEO"][10],
            Id = @"PEO.10",
            Type = @"Field",
            Position = @"PEO.10",
            Name = @"Event Expected",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0239",
            TableName = @"Event expected",
            Description = @"This field indicates whether the observed event was expected or unexpected as judged. Refer to HL7 table 0239 - Event expected for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (eventExpected.field.FieldRepetitions != null && eventExpected.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventExpected.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventExpected.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventExpected.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventExpected.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventExpected.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventExpected.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventExpected.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventExpected.fieldRepetitions = fieldRepetitions;
        }

        return eventExpected;
    } 
}

internal HL7V231Field eventOutcome;

public HL7V231Field EventOutcome
{
    get
    {
        if (eventOutcome != null)
        {
            return eventOutcome;
        }

        eventOutcome = new HL7V231Field
        {
            field = message[@"PEO"][11],
            Id = @"PEO.11",
            Type = @"Field",
            Position = @"PEO.11",
            Name = @"Event Outcome",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0240",
            TableName = @"Event consequence",
            Description = @"This field identifies the consequence of the event on the patient. If the consequence of the event is not understood or not available, the patient outcome element may be used although neither is required. May be repeated if more than one is appropriate. Refer to HL7 table 0240 - Event consequence for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (eventOutcome.field.FieldRepetitions != null && eventOutcome.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventOutcome.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventOutcome.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventOutcome.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventOutcome.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventOutcome.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventOutcome.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventOutcome.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventOutcome.fieldRepetitions = fieldRepetitions;
        }

        return eventOutcome;
    } 
}

internal HL7V231Field patientOutcome;

public HL7V231Field PatientOutcome
{
    get
    {
        if (patientOutcome != null)
        {
            return patientOutcome;
        }

        patientOutcome = new HL7V231Field
        {
            field = message[@"PEO"][12],
            Id = @"PEO.12",
            Type = @"Field",
            Position = @"PEO.12",
            Name = @"Patient Outcome",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0241",
            TableName = @"Patient outcome",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (patientOutcome.field.FieldRepetitions != null && patientOutcome.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientOutcome.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < patientOutcome.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = patientOutcome.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < patientOutcome.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = patientOutcome.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < patientOutcome.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = patientOutcome.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            patientOutcome.fieldRepetitions = fieldRepetitions;
        }

        return patientOutcome;
    } 
}

internal HL7V231Field eventDescriptionFromOthers;

public HL7V231Field EventDescriptionFromOthers
{
    get
    {
        if (eventDescriptionFromOthers != null)
        {
            return eventDescriptionFromOthers;
        }

        eventDescriptionFromOthers = new HL7V231Field
        {
            field = message[@"PEO"][13],
            Id = @"PEO.13",
            Type = @"Field",
            Position = @"PEO.13",
            Name = @"Event Description From Others",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event that occurred written by the sender. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative. By representing clinical information in OBX segments rather than in the narrative, these data become much more useful and flexible.",
            Sample = @"",
        };

        // check for repetitions
        if (eventDescriptionFromOthers.field.FieldRepetitions != null && eventDescriptionFromOthers.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventDescriptionFromOthers.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventDescriptionFromOthers.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventDescriptionFromOthers.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventDescriptionFromOthers.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventDescriptionFromOthers.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventDescriptionFromOthers.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventDescriptionFromOthers.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventDescriptionFromOthers.fieldRepetitions = fieldRepetitions;
        }

        return eventDescriptionFromOthers;
    } 
}

internal HL7V231Field eventFromOriginalReporter;

public HL7V231Field EventFromOriginalReporter
{
    get
    {
        if (eventFromOriginalReporter != null)
        {
            return eventFromOriginalReporter;
        }

        eventFromOriginalReporter = new HL7V231Field
        {
            field = message[@"PEO"][14],
            Id = @"PEO.14",
            Type = @"Field",
            Position = @"PEO.14",
            Name = @"Event From Original Reporter",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event provided by the original reporter. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.",
            Sample = @"",
        };

        // check for repetitions
        if (eventFromOriginalReporter.field.FieldRepetitions != null && eventFromOriginalReporter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventFromOriginalReporter.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventFromOriginalReporter.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventFromOriginalReporter.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventFromOriginalReporter.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventFromOriginalReporter.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventFromOriginalReporter.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventFromOriginalReporter.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventFromOriginalReporter.fieldRepetitions = fieldRepetitions;
        }

        return eventFromOriginalReporter;
    } 
}

internal HL7V231Field eventDescriptionFromPatient;

public HL7V231Field EventDescriptionFromPatient
{
    get
    {
        if (eventDescriptionFromPatient != null)
        {
            return eventDescriptionFromPatient;
        }

        eventDescriptionFromPatient = new HL7V231Field
        {
            field = message[@"PEO"][15],
            Id = @"PEO.15",
            Type = @"Field",
            Position = @"PEO.15",
            Name = @"Event Description From Patient",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event obtained directly from the patient. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative, which will allow the data to be more readily represented and manipulated.",
            Sample = @"",
        };

        // check for repetitions
        if (eventDescriptionFromPatient.field.FieldRepetitions != null && eventDescriptionFromPatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventDescriptionFromPatient.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventDescriptionFromPatient.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventDescriptionFromPatient.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventDescriptionFromPatient.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventDescriptionFromPatient.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventDescriptionFromPatient.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventDescriptionFromPatient.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventDescriptionFromPatient.fieldRepetitions = fieldRepetitions;
        }

        return eventDescriptionFromPatient;
    } 
}

internal HL7V231Field eventDescriptionFromPractitioner;

public HL7V231Field EventDescriptionFromPractitioner
{
    get
    {
        if (eventDescriptionFromPractitioner != null)
        {
            return eventDescriptionFromPractitioner;
        }

        eventDescriptionFromPractitioner = new HL7V231Field
        {
            field = message[@"PEO"][16],
            Id = @"PEO.16",
            Type = @"Field",
            Position = @"PEO.16",
            Name = @"Event Description From Practitioner",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the event provided by the practitioner most familiar with the event. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.",
            Sample = @"",
        };

        // check for repetitions
        if (eventDescriptionFromPractitioner.field.FieldRepetitions != null && eventDescriptionFromPractitioner.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventDescriptionFromPractitioner.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventDescriptionFromPractitioner.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventDescriptionFromPractitioner.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventDescriptionFromPractitioner.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventDescriptionFromPractitioner.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventDescriptionFromPractitioner.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventDescriptionFromPractitioner.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventDescriptionFromPractitioner.fieldRepetitions = fieldRepetitions;
        }

        return eventDescriptionFromPractitioner;
    } 
}

internal HL7V231Field eventDescriptionFromAutopsy;

public HL7V231Field EventDescriptionFromAutopsy
{
    get
    {
        if (eventDescriptionFromAutopsy != null)
        {
            return eventDescriptionFromAutopsy;
        }

        eventDescriptionFromAutopsy = new HL7V231Field
        {
            field = message[@"PEO"][17],
            Id = @"PEO.17",
            Type = @"Field",
            Position = @"PEO.17",
            Name = @"Event Description From Autopsy",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a summary narrative text description of the autopsy results. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.",
            Sample = @"",
        };

        // check for repetitions
        if (eventDescriptionFromAutopsy.field.FieldRepetitions != null && eventDescriptionFromAutopsy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventDescriptionFromAutopsy.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < eventDescriptionFromAutopsy.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = eventDescriptionFromAutopsy.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < eventDescriptionFromAutopsy.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = eventDescriptionFromAutopsy.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < eventDescriptionFromAutopsy.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = eventDescriptionFromAutopsy.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            eventDescriptionFromAutopsy.fieldRepetitions = fieldRepetitions;
        }

        return eventDescriptionFromAutopsy;
    } 
}

internal HL7V231Field causeOfDeath;

public HL7V231Field CauseOfDeath
{
    get
    {
        if (causeOfDeath != null)
        {
            return causeOfDeath;
        }

        causeOfDeath = new HL7V231Field
        {
            field = message[@"PEO"][18],
            Id = @"PEO.18",
            Type = @"Field",
            Position = @"PEO.18",
            Name = @"Cause Of Death",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the coded cause of death. May be repeated as necessary to list multiple contributing causes. A text description can be included by including text but no code or coding system. For example, if the cause of death is to be determined at autopsy but results are not yet available, the cause of death element could be ^Pending autopsy^. The date/time of death can be sent in the PID and the autopsy results sent in the event description from autopsy element of the PEO segment.",
            Sample = @"",
        };

        // check for repetitions
        if (causeOfDeath.field.FieldRepetitions != null && causeOfDeath.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(causeOfDeath.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < causeOfDeath.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = causeOfDeath.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < causeOfDeath.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = causeOfDeath.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < causeOfDeath.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = causeOfDeath.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            causeOfDeath.fieldRepetitions = fieldRepetitions;
        }

        return causeOfDeath;
    } 
}

internal HL7V231Field primaryObserverName;

public HL7V231Field PrimaryObserverName
{
    get
    {
        if (primaryObserverName != null)
        {
            return primaryObserverName;
        }

        primaryObserverName = new HL7V231Field
        {
            field = message[@"PEO"][19],
            Id = @"PEO.19",
            Type = @"Field",
            Position = @"PEO.19",
            Name = @"Primary Observer Name",
            Length = 46,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the name of the person who initially described the event.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryObserverName.field.FieldRepetitions != null && primaryObserverName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryObserverName.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < primaryObserverName.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = primaryObserverName.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryObserverName.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = primaryObserverName.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < primaryObserverName.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = primaryObserverName.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryObserverName.fieldRepetitions = fieldRepetitions;
        }

        return primaryObserverName;
    } 
}

internal HL7V231Field primaryObserverAddress;

public HL7V231Field PrimaryObserverAddress
{
    get
    {
        if (primaryObserverAddress != null)
        {
            return primaryObserverAddress;
        }

        primaryObserverAddress = new HL7V231Field
        {
            field = message[@"PEO"][20],
            Id = @"PEO.20",
            Type = @"Field",
            Position = @"PEO.20",
            Name = @"Primary Observer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the address of the person who initially described the event.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryObserverAddress.field.FieldRepetitions != null && primaryObserverAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryObserverAddress.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < primaryObserverAddress.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = primaryObserverAddress.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryObserverAddress.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = primaryObserverAddress.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < primaryObserverAddress.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = primaryObserverAddress.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryObserverAddress.fieldRepetitions = fieldRepetitions;
        }

        return primaryObserverAddress;
    } 
}

internal HL7V231Field primaryObserverTelephone;

public HL7V231Field PrimaryObserverTelephone
{
    get
    {
        if (primaryObserverTelephone != null)
        {
            return primaryObserverTelephone;
        }

        primaryObserverTelephone = new HL7V231Field
        {
            field = message[@"PEO"][21],
            Id = @"PEO.21",
            Type = @"Field",
            Position = @"PEO.21",
            Name = @"Primary Observer Telephone",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the telephone number of the person who initially described the event.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryObserverTelephone.field.FieldRepetitions != null && primaryObserverTelephone.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryObserverTelephone.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < primaryObserverTelephone.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = primaryObserverTelephone.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryObserverTelephone.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = primaryObserverTelephone.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < primaryObserverTelephone.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = primaryObserverTelephone.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryObserverTelephone.fieldRepetitions = fieldRepetitions;
        }

        return primaryObserverTelephone;
    } 
}

internal HL7V231Field primaryObserversQualification;

public HL7V231Field PrimaryObserversQualification
{
    get
    {
        if (primaryObserversQualification != null)
        {
            return primaryObserversQualification;
        }

        primaryObserversQualification = new HL7V231Field
        {
            field = message[@"PEO"][22],
            Id = @"PEO.22",
            Type = @"Field",
            Position = @"PEO.22",
            Name = @"Primary Observer s Qualification",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0242",
            TableName = @"Primary observer’s qualification",
            Description = @"This field contains the qualification of the primary observer which may assist in assessing the validity of the observations. Refer to HL7 table 0242 - Primary observer's qualification for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryObserversQualification.field.FieldRepetitions != null && primaryObserversQualification.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryObserversQualification.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < primaryObserversQualification.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = primaryObserversQualification.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryObserversQualification.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = primaryObserversQualification.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < primaryObserversQualification.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = primaryObserversQualification.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryObserversQualification.fieldRepetitions = fieldRepetitions;
        }

        return primaryObserversQualification;
    } 
}

internal HL7V231Field confirmationProvidedBy;

public HL7V231Field ConfirmationProvidedBy
{
    get
    {
        if (confirmationProvidedBy != null)
        {
            return confirmationProvidedBy;
        }

        confirmationProvidedBy = new HL7V231Field
        {
            field = message[@"PEO"][23],
            Id = @"PEO.23",
            Type = @"Field",
            Position = @"PEO.23",
            Name = @"Confirmation Provided By",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0242",
            TableName = @"Primary observer’s qualification",
            Description = @"This field contains the qualification of the health professional who confirmed the observation if the primary observer was not a health professional. Refer to HL7 table 0242 - Primary observer'squalification for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (confirmationProvidedBy.field.FieldRepetitions != null && confirmationProvidedBy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(confirmationProvidedBy.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < confirmationProvidedBy.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = confirmationProvidedBy.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < confirmationProvidedBy.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = confirmationProvidedBy.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < confirmationProvidedBy.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = confirmationProvidedBy.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            confirmationProvidedBy.fieldRepetitions = fieldRepetitions;
        }

        return confirmationProvidedBy;
    } 
}

internal HL7V231Field primaryObserverAwareDateTime;

public HL7V231Field PrimaryObserverAwareDateTime
{
    get
    {
        if (primaryObserverAwareDateTime != null)
        {
            return primaryObserverAwareDateTime;
        }

        primaryObserverAwareDateTime = new HL7V231Field
        {
            field = message[@"PEO"][24],
            Id = @"PEO.24",
            Type = @"Field",
            Position = @"PEO.24",
            Name = @"Primary Observer Aware Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the date/time the primary observer became aware of event.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryObserverAwareDateTime.field.FieldRepetitions != null && primaryObserverAwareDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryObserverAwareDateTime.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < primaryObserverAwareDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = primaryObserverAwareDateTime.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryObserverAwareDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = primaryObserverAwareDateTime.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < primaryObserverAwareDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = primaryObserverAwareDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryObserverAwareDateTime.fieldRepetitions = fieldRepetitions;
        }

        return primaryObserverAwareDateTime;
    } 
}

internal HL7V231Field primaryObserversidentityMayBeDivulged;

public HL7V231Field PrimaryObserversidentityMayBeDivulged
{
    get
    {
        if (primaryObserversidentityMayBeDivulged != null)
        {
            return primaryObserversidentityMayBeDivulged;
        }

        primaryObserversidentityMayBeDivulged = new HL7V231Field
        {
            field = message[@"PEO"][25],
            Id = @"PEO.25",
            Type = @"Field",
            Position = @"PEO.25",
            Name = @"Primary Observer s identity May Be Divulged",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0243",
            TableName = @"Identity may be divulged",
            Description = @"Indicates whether or not the primary observer, if known to the sender, grants permission to disclose his or her identity to the product manufacturer for the purpose of further investigating the event. If the element is absent, the assumption should be made that permission is not granted. Refer to HL7 table 0243 - Identity may be divulged for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryObserversidentityMayBeDivulged.field.FieldRepetitions != null && primaryObserversidentityMayBeDivulged.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryObserversidentityMayBeDivulged.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < primaryObserversidentityMayBeDivulged.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = primaryObserversidentityMayBeDivulged.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryObserversidentityMayBeDivulged.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = primaryObserversidentityMayBeDivulged.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < primaryObserversidentityMayBeDivulged.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = primaryObserversidentityMayBeDivulged.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = componentFieldData.Id,
                                    Type = componentFieldData.Type,
                                    Position = componentFieldData.Position,
                                    Name = componentFieldData.Name,
                                    Length = componentFieldData.Length,
                                    Usage = componentFieldData.Usage,
                                    Rpt = componentFieldData.Rpt,
                                    DataType = componentFieldData.DataType,
                                    DataTypeName = componentFieldData.DataTypeName,
                                    TableId = componentFieldData.TableId,
                                    TableName = componentFieldData.TableName,
                                    Description = componentFieldData.Description,
                                    Sample = componentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryObserversidentityMayBeDivulged.fieldRepetitions = fieldRepetitions;
        }

        return primaryObserversidentityMayBeDivulged;
    } 
}

    }
}