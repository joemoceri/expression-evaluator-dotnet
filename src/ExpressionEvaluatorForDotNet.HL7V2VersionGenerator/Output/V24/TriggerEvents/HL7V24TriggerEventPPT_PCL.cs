using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventPPT_PCL
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentMSA msa;
public readonly HL7V24SegmentERR err;
public readonly HL7V24SegmentQAK qak;
public readonly HL7V24SegmentQRD qrd;


        public string Id { get { return @"PPT_PCL"; } }
        public string MessageStructureId { get { return @"PPT_PCL"; } }
        public string EventDescription { get { return @"Pathway (goal-oriented) query response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",
                    };
            }
        }

        public HL7V24TriggerEventPPT_PCL(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);

        }
    }
}
