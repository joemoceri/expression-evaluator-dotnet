using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventOMI_O23
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentNTE nte{ get; init; }


        public string Id { get { return @"OMI_O23"; } }
        public string MessageStructureId { get { return @"OMI_O23"; } }
        public string EventDescription { get { return @"Imaging Order"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V26TriggerEventOMI_O23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
