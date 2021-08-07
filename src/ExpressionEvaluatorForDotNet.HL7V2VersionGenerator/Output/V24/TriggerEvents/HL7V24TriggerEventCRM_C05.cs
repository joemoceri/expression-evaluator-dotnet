using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventCRM_C05
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;


        public string Id { get { return @"CRM_C05"; } }
        public string MessageStructureId { get { return @"CRM_C05"; } }
        public string EventDescription { get { return @"Patient enters phase of clinical trial"; } }

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

        public HL7V24TriggerEventCRM_C05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);

        }
    }
}
