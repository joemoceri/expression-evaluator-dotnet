using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMFN_M07
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentMFI mfi;


        public string Id { get { return @"MFN_M07"; } }
        public string MessageStructureId { get { return @"MFN_M07"; } }
        public string EventDescription { get { return @"Master files notification - Clinical study without phases but with schedules master file"; } }

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

        public HL7V25TriggerEventMFN_M07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.mfi = new HL7V25SegmentMFI(this.message);

        }
    }
}