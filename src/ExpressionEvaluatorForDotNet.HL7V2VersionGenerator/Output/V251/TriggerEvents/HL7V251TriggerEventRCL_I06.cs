using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRCL_I06
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentMSA msa{ get; init; }
public HL7V251SegmentQRD qrd{ get; init; }
public HL7V251SegmentQRF qrf{ get; init; }
public HL7V251SegmentPID pid{ get; init; }
public HL7V251SegmentDG1 dg1{ get; init; }
public HL7V251SegmentDRG drg{ get; init; }
public HL7V251SegmentAL1 al1{ get; init; }
public HL7V251SegmentNTE nte{ get; init; }
public HL7V251SegmentDSP dsp{ get; init; }
public HL7V251SegmentDSC dsc{ get; init; }


        public string Id { get { return @"RCL_I06"; } }
        public string MessageStructureId { get { return @"RCL_I06"; } }
        public string EventDescription { get { return @"Request/receipt of clinical data listing acknowledgement"; } }

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

        public HL7V251TriggerEventRCL_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);
this.al1 = new HL7V251SegmentAL1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);
this.dsp = new HL7V251SegmentDSP(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
