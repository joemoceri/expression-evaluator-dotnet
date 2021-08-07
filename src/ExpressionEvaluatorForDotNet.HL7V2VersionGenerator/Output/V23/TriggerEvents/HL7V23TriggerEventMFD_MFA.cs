using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMFD_MFA
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMFI mfi;
public readonly HL7V23SegmentMFA mfa;


        public string Id { get { return @"MFD_MFA"; } }
        public string MessageStructureId { get { return @"MFD_MFA"; } }
        public string EventDescription { get { return @"Master file delayed application acknowledgment"; } }

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

        public HL7V23TriggerEventMFD_MFA(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);
this.mfa = new HL7V23SegmentMFA(this.message);

        }
    }
}
