using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRCL_I06
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentMSA msa{ get; init; }
public HL7V25SegmentQRD qrd{ get; init; }
public HL7V25SegmentQRF qrf{ get; init; }
public HL7V25SegmentPID pid{ get; init; }
public HL7V25SegmentDG1 dg1{ get; init; }
public HL7V25SegmentDRG drg{ get; init; }
public HL7V25SegmentAL1 al1{ get; init; }
public HL7V25SegmentNTE nte{ get; init; }
public HL7V25SegmentDSP dsp{ get; init; }
public HL7V25SegmentDSC dsc{ get; init; }


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

        public HL7V25TriggerEventRCL_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);
this.drg = new HL7V25SegmentDRG(this.message);
this.al1 = new HL7V25SegmentAL1(this.message);
this.nte = new HL7V25SegmentNTE(this.message);
this.dsp = new HL7V25SegmentDSP(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
