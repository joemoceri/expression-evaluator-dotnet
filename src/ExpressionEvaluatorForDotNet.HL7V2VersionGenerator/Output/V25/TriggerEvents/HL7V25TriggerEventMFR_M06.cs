using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMFR_M06
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentMSA msa;
public readonly HL7V25SegmentERR err;
public readonly HL7V25SegmentQAK qak;
public readonly HL7V25SegmentQRD qrd;
public readonly HL7V25SegmentQRF qrf;
public readonly HL7V25SegmentMFI mfi;
public readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"MFR_M06"; } }
        public string MessageStructureId { get { return @"MFR_M06"; } }
        public string EventDescription { get { return @"Master Files Response - Clinical study with phases and schedules master file"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
                    };
            }
        }

        public HL7V25TriggerEventMFR_M06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);
this.mfi = new HL7V25SegmentMFI(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}