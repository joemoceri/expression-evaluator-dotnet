using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventPPR_PC3
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentPID pid;


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

        public HL7V24TriggerEventPPR_PC3(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.pid = new HL7V24SegmentPID(this.message);

        }
    }
}