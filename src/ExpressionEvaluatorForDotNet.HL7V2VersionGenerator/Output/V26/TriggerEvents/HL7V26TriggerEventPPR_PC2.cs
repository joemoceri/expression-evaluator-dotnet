using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventPPR_PC2
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentPID pid;


        public string Id { get { return @"PPR_PC2"; } }
        public string MessageStructureId { get { return @"PPR_PC2"; } }
        public string EventDescription { get { return @"Patient Problem Update"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",
                    };
            }
        }

        public HL7V26TriggerEventPPR_PC2(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.pid = new HL7V26SegmentPID(this.message);

        }
    }
}
