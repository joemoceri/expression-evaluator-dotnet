using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventNMR_N01
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentMSA msa;
public readonly HL7V26SegmentERR err;
public readonly HL7V26SegmentQRD qrd;


        public string Id { get { return @"NMR_N01"; } }
        public string MessageStructureId { get { return @"NMR_N01"; } }
        public string EventDescription { get { return @"Application Management Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",
                    };
            }
        }

        public HL7V26TriggerEventNMR_N01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);

        }
    }
}
