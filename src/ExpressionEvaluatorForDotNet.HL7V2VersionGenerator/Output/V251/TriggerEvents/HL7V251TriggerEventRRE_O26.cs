using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRRE_O26
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentMSA msa{ get; init; }
public HL7V251SegmentERR err{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentNTE nte{ get; init; }


        public string Id { get { return @"RRE_O26"; } }
        public string MessageStructureId { get { return @"RRE_O26"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Refill Authorization Request Acknowledgment"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V251TriggerEventRRE_O26(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
