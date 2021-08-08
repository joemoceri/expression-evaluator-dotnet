using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventSIU_S21
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentSCH sch;
public readonly HL7V23SegmentNTE nte;


        public string Id { get { return @"SIU_S21"; } }
        public string MessageStructureId { get { return @"SIU_S21"; } }
        public string EventDescription { get { return @"Notification of discontinuation of service/resource on appointment"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
                    };
            }
        }

        public HL7V23TriggerEventSIU_S21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.sch = new HL7V23SegmentSCH(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}