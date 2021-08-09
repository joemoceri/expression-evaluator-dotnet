using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventQVR_Q17
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentQPD qpd{ get; init; }
public HL7V27SegmentRCP rcp{ get; init; }
public HL7V27SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QVR_Q17"; } }
        public string MessageStructureId { get { return @"QVR_Q17"; } }
        public string EventDescription { get { return @"Query for previous events"; } }

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

        public HL7V27TriggerEventQVR_Q17(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.qpd = new HL7V27SegmentQPD(this.message);
this.rcp = new HL7V27SegmentRCP(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}
