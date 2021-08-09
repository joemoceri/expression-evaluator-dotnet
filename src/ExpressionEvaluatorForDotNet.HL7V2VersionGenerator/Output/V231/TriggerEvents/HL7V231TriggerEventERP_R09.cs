using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventERP_R09
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMSA msa{ get; init; }
public HL7V231SegmentERR err{ get; init; }
public HL7V231SegmentQAK qak{ get; init; }
public HL7V231SegmentERQ erq{ get; init; }
public HL7V231SegmentDSC dsc{ get; init; }


        public string Id { get { return @"ERP_R09"; } }
        public string MessageStructureId { get { return @"ERP_R09"; } }
        public string EventDescription { get { return @"Event replay response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V231TriggerEventERP_R09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.qak = new HL7V231SegmentQAK(this.message);
this.erq = new HL7V231SegmentERQ(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
