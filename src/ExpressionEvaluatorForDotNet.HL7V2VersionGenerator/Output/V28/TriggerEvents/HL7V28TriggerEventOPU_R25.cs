using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventOPU_R25
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentNTE nte;
public readonly HL7V28SegmentPV1 pv1;
public readonly HL7V28SegmentPV2 pv2;
public readonly HL7V28SegmentPRT prt;


        public string Id { get { return @"OPU_R25"; } }
        public string MessageStructureId { get { return @"OPU_R25"; } }
        public string EventDescription { get { return @"Unsolicited Population/Location-Based Laboratory Observation Message"; } }

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

        public HL7V28TriggerEventOPU_R25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.nte = new HL7V28SegmentNTE(this.message);
this.pv1 = new HL7V28SegmentPV1(this.message);
this.pv2 = new HL7V28SegmentPV2(this.message);
this.prt = new HL7V28SegmentPRT(this.message);

        }
    }
}
