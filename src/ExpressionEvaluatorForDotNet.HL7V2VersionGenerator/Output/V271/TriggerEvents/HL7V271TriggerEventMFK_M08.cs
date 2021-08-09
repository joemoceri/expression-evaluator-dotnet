using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventMFK_M08
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentMSA msa{ get; init; }
public HL7V271SegmentERR err{ get; init; }
public HL7V271SegmentMFI mfi{ get; init; }
public HL7V271SegmentMFA mfa{ get; init; }


        public string Id { get { return @"MFK_M08"; } }
        public string MessageStructureId { get { return @"MFK_M08"; } }
        public string EventDescription { get { return @"Test/Observation (Numeric) Master File Application Acknowledgment"; } }

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

        public HL7V271TriggerEventMFK_M08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.mfi = new HL7V271SegmentMFI(this.message);
this.mfa = new HL7V271SegmentMFA(this.message);

        }
    }
}
