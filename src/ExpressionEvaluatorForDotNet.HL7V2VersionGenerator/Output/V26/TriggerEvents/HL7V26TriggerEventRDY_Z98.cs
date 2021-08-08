using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRDY_Z98
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentMSA msa;
public readonly HL7V26SegmentERR err;
public readonly HL7V26SegmentQAK qak;
public readonly HL7V26SegmentQPD qpd;
public readonly HL7V26SegmentDSP dsp;
public readonly HL7V26SegmentDSC dsc;


        public string Id { get { return @"RDY_Z98"; } }
        public string MessageStructureId { get { return @"RDY_Z98"; } }
        public string EventDescription { get { return @"Dispense History Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V26TriggerEventRDY_Z98(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.qpd = new HL7V26SegmentQPD(this.message);
this.dsp = new HL7V26SegmentDSP(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}