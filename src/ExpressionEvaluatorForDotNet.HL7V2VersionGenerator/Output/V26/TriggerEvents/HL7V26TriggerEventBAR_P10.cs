using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventBAR_P10
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentEVN evn{ get; init; }
public HL7V26SegmentPID pid{ get; init; }
public HL7V26SegmentPV1 pv1{ get; init; }
public HL7V26SegmentDG1 dg1{ get; init; }
public HL7V26SegmentGP1 gp1{ get; init; }


        public string Id { get { return @"BAR_P10"; } }
        public string MessageStructureId { get { return @"BAR_P10"; } }
        public string EventDescription { get { return @"Transmit Ambulatory Payment Classification (APC)"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V26TriggerEventBAR_P10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pv1 = new HL7V26SegmentPV1(this.message);
this.dg1 = new HL7V26SegmentDG1(this.message);
this.gp1 = new HL7V26SegmentGP1(this.message);

        }
    }
}
