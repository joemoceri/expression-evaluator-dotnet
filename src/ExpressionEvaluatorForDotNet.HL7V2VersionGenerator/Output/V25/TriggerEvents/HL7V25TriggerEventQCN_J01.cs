using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventQCN_J01
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentQID qid;


        public string Id { get { return @"QCN_J01"; } }
        public string MessageStructureId { get { return @"QCN_J01"; } }
        public string EventDescription { get { return @"Cancel Query"; } }

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

        public HL7V25TriggerEventQCN_J01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qid = new HL7V25SegmentQID(this.message);

        }
    }
}