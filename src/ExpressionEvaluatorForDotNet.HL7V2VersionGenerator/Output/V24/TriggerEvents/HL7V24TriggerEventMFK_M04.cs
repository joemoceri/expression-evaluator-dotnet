using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFK_M04
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentMSA msa{ get; init; }
public HL7V24SegmentMFI mfi{ get; init; }
public HL7V24SegmentMFA mfa{ get; init; }


        public string Id { get { return @"MFK_M04"; } }
        public string MessageStructureId { get { return @"MFK_M04"; } }
        public string EventDescription { get { return @"Master file acknowledgment - Charge description master file"; } }

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

        public HL7V24TriggerEventMFK_M04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);
this.mfa = new HL7V24SegmentMFA(this.message);

        }
    }
}
