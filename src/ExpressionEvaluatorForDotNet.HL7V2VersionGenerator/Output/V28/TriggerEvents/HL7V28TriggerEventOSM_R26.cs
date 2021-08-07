using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventOSM_R26
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;


        public string Id { get { return @"OSM_R26"; } }
        public string MessageStructureId { get { return @"OSM_R26"; } }
        public string EventDescription { get { return @"Unsolicited Specimen Shipment Manifest Message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
                    };
            }
        }

        public HL7V28TriggerEventOSM_R26(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);

        }
    }
}
