using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventPGL_PC7
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentPID pid{ get; init; }


        public string Id { get { return @"PGL_PC7"; } }
        public string MessageStructureId { get { return @"PGL_PC7"; } }
        public string EventDescription { get { return @"Goal update"; } }

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

        public HL7V23TriggerEventPGL_PC7(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.pid = new HL7V23SegmentPID(this.message);

        }
    }
}
