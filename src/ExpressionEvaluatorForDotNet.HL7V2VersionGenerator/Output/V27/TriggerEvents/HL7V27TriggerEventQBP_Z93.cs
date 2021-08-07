using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventQBP_Z93
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentQPD qpd;
public readonly HL7V27SegmentRDF rdf;
public readonly HL7V27SegmentRCP rcp;
public readonly HL7V27SegmentDSC dsc;


        public string Id { get { return @"QBP_Z93"; } }
        public string MessageStructureId { get { return @"QBP_Z93"; } }
        public string EventDescription { get { return @"Tabular Dispense History"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V27TriggerEventQBP_Z93(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.qpd = new HL7V27SegmentQPD(this.message);
this.rdf = new HL7V27SegmentRDF(this.message);
this.rcp = new HL7V27SegmentRCP(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}
