using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventPPR_PC3
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentPID pid;


        public string Id { get { return @"PPR_PC3"; } }
        public string MessageStructureId { get { return @"PPR_PC3"; } }
        public string EventDescription { get { return @"Problem delete"; } }

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

        public HL7V23TriggerEventPPR_PC3(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.pid = new HL7V23SegmentPID(this.message);

        }
    }
}