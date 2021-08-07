using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRPA_I11
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentMSA msa;
public readonly HL7V27SegmentRF1 rf1;
public readonly HL7V27SegmentPID pid;
public readonly HL7V27SegmentNK1 nk1;
public readonly HL7V27SegmentGT1 gt1;
public readonly HL7V27SegmentACC acc;
public readonly HL7V27SegmentDG1 dg1;
public readonly HL7V27SegmentDRG drg;
public readonly HL7V27SegmentAL1 al1;
public readonly HL7V27SegmentNTE nte;


        public string Id { get { return @"RPA_I11"; } }
        public string MessageStructureId { get { return @"RPA_I11"; } }
        public string EventDescription { get { return @"Return Cancellation of an Authorization"; } }

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

        public HL7V27TriggerEventRPA_I11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
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
