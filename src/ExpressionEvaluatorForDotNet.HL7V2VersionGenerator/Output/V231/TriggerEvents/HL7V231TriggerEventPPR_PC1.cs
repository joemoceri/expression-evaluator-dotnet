using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventPPR_PC1
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentPID pid;


        public string Id { get { return @"PPR_PC1"; } }
        public string MessageStructureId { get { return @"PPR_PC1"; } }
        public string EventDescription { get { return @"Problem add"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",
                    };
            }
        }

        public HL7V231TriggerEventPPR_PC1(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.pid = new HL7V231SegmentPID(this.message);

        }
    }
}
