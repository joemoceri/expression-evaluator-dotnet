using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFN_M05
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentMFI mfi;


        public string Id { get { return @"MFN_M05"; } }
        public string MessageStructureId { get { return @"MFN_M05"; } }
        public string EventDescription { get { return @"Master files notification - Patient location master file"; } }

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

        public HL7V24TriggerEventMFN_M05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);

        }
    }
}
