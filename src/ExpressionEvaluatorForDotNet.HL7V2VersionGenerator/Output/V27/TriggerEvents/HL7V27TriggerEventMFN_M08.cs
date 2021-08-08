using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventMFN_M08
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentMFI mfi;


        public string Id { get { return @"MFN_M08"; } }
        public string MessageStructureId { get { return @"MFN_M08"; } }
        public string EventDescription { get { return @"Test/observation (numeric) master file"; } }

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

        public HL7V27TriggerEventMFN_M08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.mfi = new HL7V27SegmentMFI(this.message);

        }
    }
}