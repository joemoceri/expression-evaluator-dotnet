using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventSRM_S06
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentARQ arq{ get; init; }
public HL7V24SegmentAPR apr{ get; init; }
public HL7V24SegmentNTE nte{ get; init; }


        public string Id { get { return @"SRM_S06"; } }
        public string MessageStructureId { get { return @"SRM_S06"; } }
        public string EventDescription { get { return @"Schedule request - Appointment deletion"; } }

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

        public HL7V24TriggerEventSRM_S06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.arq = new HL7V24SegmentARQ(this.message);
this.apr = new HL7V24SegmentAPR(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
