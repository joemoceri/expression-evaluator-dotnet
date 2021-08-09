using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventCSU_C12
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }


        public string Id { get { return @"CSU_C12"; } }
        public string MessageStructureId { get { return @"CSU_C12"; } }
        public string EventDescription { get { return @"Update/correction of patient order/result information"; } }

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

        public HL7V24TriggerEventCSU_C12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);

        }
    }
}
