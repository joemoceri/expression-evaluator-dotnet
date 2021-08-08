using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventCRM_C03
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;


        public string Id { get { return @"CRM_C03"; } }
        public string MessageStructureId { get { return @"CRM_C03"; } }
        public string EventDescription { get { return @"Correct/update registration information"; } }

        public string Sample { get { return null; } }

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

        public HL7V25TriggerEventCRM_C03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);

        }
    }
}