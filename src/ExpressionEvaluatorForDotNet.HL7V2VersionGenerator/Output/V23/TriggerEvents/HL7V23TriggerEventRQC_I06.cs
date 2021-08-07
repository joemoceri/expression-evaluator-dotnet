using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRQC_I06
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentQRD qrd;
public readonly HL7V23SegmentQRF qrf;
public readonly HL7V23SegmentPID pid;
public readonly HL7V23SegmentNK1 nk1;
public readonly HL7V23SegmentGT1 gt1;
public readonly HL7V23SegmentNTE nte;


        public string Id { get { return @"RQC_I06"; } }
        public string MessageStructureId { get { return @"RQC_I06"; } }
        public string EventDescription { get { return @"Request/receipt of clinical data listing"; } }

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

        public HL7V23TriggerEventRQC_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.nk1 = new HL7V23SegmentNK1(this.message);
this.gt1 = new HL7V23SegmentGT1(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
