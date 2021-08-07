using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRRI_I12
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentRF1 rf1;
public readonly HL7V23SegmentPID pid;
public readonly HL7V23SegmentACC acc;
public readonly HL7V23SegmentDG1 dg1;
public readonly HL7V23SegmentDRG drg;
public readonly HL7V23SegmentAL1 al1;
public readonly HL7V23SegmentNTE nte;


        public string Id { get { return @"RRI_I12"; } }
        public string MessageStructureId { get { return @"RRI_I12"; } }
        public string EventDescription { get { return @"Response patient referral"; } }

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

        public HL7V23TriggerEventRRI_I12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.rf1 = new HL7V23SegmentRF1(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.acc = new HL7V23SegmentACC(this.message);
this.dg1 = new HL7V23SegmentDG1(this.message);
this.drg = new HL7V23SegmentDRG(this.message);
this.al1 = new HL7V23SegmentAL1(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
