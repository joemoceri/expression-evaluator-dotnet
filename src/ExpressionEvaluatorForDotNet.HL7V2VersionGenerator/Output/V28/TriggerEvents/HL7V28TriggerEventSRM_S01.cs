using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSRM_S01
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentARQ arq{ get; init; }
public HL7V28SegmentAPR apr{ get; init; }
public HL7V28SegmentNTE nte{ get; init; }


        public string Id { get { return @"SRM_S01"; } }
        public string MessageStructureId { get { return @"SRM_S01"; } }
        public string EventDescription { get { return @"Request new appointment booking"; } }

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

        public HL7V28TriggerEventSRM_S01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.arq = new HL7V28SegmentARQ(this.message);
this.apr = new HL7V28SegmentAPR(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
