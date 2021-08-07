using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventSPQ_Q08
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentSPR spr;
public readonly HL7V231SegmentRDF rdf;
public readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"SPQ_Q08"; } }
        public string MessageStructureId { get { return @"SPQ_Q08"; } }
        public string EventDescription { get { return @"Stored procedure request"; } }

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

        public HL7V231TriggerEventSPQ_Q08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.spr = new HL7V231SegmentSPR(this.message);
this.rdf = new HL7V231SegmentRDF(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
