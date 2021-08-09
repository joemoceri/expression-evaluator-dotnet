using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventEHC_E02
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }


        public string Id { get { return @"EHC_E02"; } }
        public string MessageStructureId { get { return @"EHC_E02"; } }
        public string EventDescription { get { return @"Cancel HealthCare Services Invoice"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",

                    };
            }
        }

        public HL7V26TriggerEventEHC_E02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);

        }
    }
}
