using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventORD_O02
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentMSA msa{ get; init; }
public HL7V23SegmentERR err{ get; init; }
public HL7V23SegmentNTE nte{ get; init; }


        public string Id { get { return @"ORD_O02"; } }
        public string MessageStructureId { get { return @"ORD_O02"; } }
        public string EventDescription { get { return @"Dietary order acknowledgment message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V23TriggerEventORD_O02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
