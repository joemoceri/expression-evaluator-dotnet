using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventREF_I15
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentRF1 rf1{ get; init; }
public HL7V27SegmentPID pid{ get; init; }
public HL7V27SegmentNK1 nk1{ get; init; }
public HL7V27SegmentGT1 gt1{ get; init; }
public HL7V27SegmentACC acc{ get; init; }
public HL7V27SegmentDG1 dg1{ get; init; }
public HL7V27SegmentDRG drg{ get; init; }
public HL7V27SegmentAL1 al1{ get; init; }
public HL7V27SegmentNTE nte{ get; init; }


        public string Id { get { return @"REF_I15"; } }
        public string MessageStructureId { get { return @"REF_I15"; } }
        public string EventDescription { get { return @"Request patient referral status"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V27TriggerEventREF_I15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.rf1 = new HL7V27SegmentRF1(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.gt1 = new HL7V27SegmentGT1(this.message);
this.acc = new HL7V27SegmentACC(this.message);
this.dg1 = new HL7V27SegmentDG1(this.message);
this.drg = new HL7V27SegmentDRG(this.message);
this.al1 = new HL7V27SegmentAL1(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
