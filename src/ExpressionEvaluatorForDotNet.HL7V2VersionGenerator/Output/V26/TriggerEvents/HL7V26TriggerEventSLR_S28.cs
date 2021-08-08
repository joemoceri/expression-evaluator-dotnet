using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSLR_S28
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentSLT slt;


        public string Id { get { return @"SLR_S28"; } }
        public string MessageStructureId { get { return @"SLR_S28"; } }
        public string EventDescription { get { return @"Request New Sterilization Lot"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
                    };
            }
        }

        public HL7V26TriggerEventSLR_S28(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.slt = new HL7V26SegmentSLT(this.message);

        }
    }
}