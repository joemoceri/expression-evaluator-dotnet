using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMFN_M03
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentMFI mfi;


        public string Id { get { return @"MFN_M03"; } }
        public string MessageStructureId { get { return @"MFN_M03"; } }
        public string EventDescription { get { return @"Master file - Test/Observation"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
                    };
            }
        }

        public HL7V231TriggerEventMFN_M03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.mfi = new HL7V231SegmentMFI(this.message);

        }
    }
}
