using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventQSB_Q16
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentQPD qpd;
public readonly HL7V25SegmentRCP rcp;
public readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"QSB_Q16"; } }
        public string MessageStructureId { get { return @"QSB_Q16"; } }
        public string EventDescription { get { return @"Create Subscription"; } }

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

        public HL7V25TriggerEventQSB_Q16(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qpd = new HL7V25SegmentQPD(this.message);
this.rcp = new HL7V25SegmentRCP(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
