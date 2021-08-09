using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventMFK_M06
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentMSA msa{ get; init; }
public HL7V27SegmentERR err{ get; init; }
public HL7V27SegmentMFI mfi{ get; init; }
public HL7V27SegmentMFA mfa{ get; init; }


        public string Id { get { return @"MFK_M06"; } }
        public string MessageStructureId { get { return @"MFK_M06"; } }
        public string EventDescription { get { return @"Clinical Study with Phases and Schedules Master File Application Acknowledgment"; } }

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

        public HL7V27TriggerEventMFK_M06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.mfi = new HL7V27SegmentMFI(this.message);
this.mfa = new HL7V27SegmentMFA(this.message);

        }
    }
}
