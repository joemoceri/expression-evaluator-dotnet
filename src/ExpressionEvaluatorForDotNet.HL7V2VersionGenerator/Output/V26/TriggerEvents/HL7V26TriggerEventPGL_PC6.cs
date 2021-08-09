using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventPGL_PC6
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentPID pid{ get; init; }


        public string Id { get { return @"PGL_PC6"; } }
        public string MessageStructureId { get { return @"PGL_PC6"; } }
        public string EventDescription { get { return @"Patient Goal Add"; } }

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

        public HL7V26TriggerEventPGL_PC6(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.pid = new HL7V26SegmentPID(this.message);

        }
    }
}
