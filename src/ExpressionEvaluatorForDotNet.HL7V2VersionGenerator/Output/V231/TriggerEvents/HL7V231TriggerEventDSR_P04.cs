using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventDSR_P04
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentMSA msa;
public readonly HL7V231SegmentERR err;
public readonly HL7V231SegmentQAK qak;
public readonly HL7V231SegmentQRD qrd;
public readonly HL7V231SegmentQRF qrf;
public readonly HL7V231SegmentDSP dsp;
public readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"DSR_P04"; } }
        public string MessageStructureId { get { return @"DSR_P04"; } }
        public string EventDescription { get { return @"Display response message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
                    };
            }
        }

        public HL7V231TriggerEventDSR_P04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.qak = new HL7V231SegmentQAK(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);
this.dsp = new HL7V231SegmentDSP(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}