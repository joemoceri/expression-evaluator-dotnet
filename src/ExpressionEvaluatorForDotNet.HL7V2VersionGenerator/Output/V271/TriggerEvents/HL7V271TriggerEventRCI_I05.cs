using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRCI_I05
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentMSA msa{ get; init; }
public HL7V271SegmentQRD qrd{ get; init; }
public HL7V271SegmentQRF qrf{ get; init; }
public HL7V271SegmentPID pid{ get; init; }
public HL7V271SegmentDG1 dg1{ get; init; }
public HL7V271SegmentDRG drg{ get; init; }
public HL7V271SegmentAL1 al1{ get; init; }
public HL7V271SegmentNTE nte{ get; init; }


        public string Id { get { return @"RCI_I05"; } }
        public string MessageStructureId { get { return @"RCI_I05"; } }
        public string EventDescription { get { return @"Return clinical information"; } }

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

        public HL7V271TriggerEventRCI_I05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.qrd = new HL7V271SegmentQRD(this.message);
this.qrf = new HL7V271SegmentQRF(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.dg1 = new HL7V271SegmentDG1(this.message);
this.drg = new HL7V271SegmentDRG(this.message);
this.al1 = new HL7V271SegmentAL1(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
