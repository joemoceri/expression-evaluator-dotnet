using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSIU_S23
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSCH sch;
public readonly HL7V27SegmentTQ1 tq1;
public readonly HL7V27SegmentNTE nte;


        public string Id { get { return @"SIU_S23"; } }
        public string MessageStructureId { get { return @"SIU_S23"; } }
        public string EventDescription { get { return @"Notification of blocked schedule time slot(s)"; } }

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

        public HL7V27TriggerEventSIU_S23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sch = new HL7V27SegmentSCH(this.message);
this.tq1 = new HL7V27SegmentTQ1(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}