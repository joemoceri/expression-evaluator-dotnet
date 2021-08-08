using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventREF_I15
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentRF1 rf1;
public readonly HL7V28SegmentPID pid;
public readonly HL7V28SegmentNK1 nk1;
public readonly HL7V28SegmentGT1 gt1;
public readonly HL7V28SegmentACC acc;
public readonly HL7V28SegmentDG1 dg1;
public readonly HL7V28SegmentDRG drg;
public readonly HL7V28SegmentAL1 al1;
public readonly HL7V28SegmentNTE nte;


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

        public HL7V28TriggerEventREF_I15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.rf1 = new HL7V28SegmentRF1(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.gt1 = new HL7V28SegmentGT1(this.message);
this.acc = new HL7V28SegmentACC(this.message);
this.dg1 = new HL7V28SegmentDG1(this.message);
this.drg = new HL7V28SegmentDRG(this.message);
this.al1 = new HL7V28SegmentAL1(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}