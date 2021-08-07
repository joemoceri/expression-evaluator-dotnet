using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventRAR_RAR
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentMSA msa;
public readonly HL7V22SegmentERR err;
public readonly HL7V22SegmentDSC dsc;


        public string Id { get { return @"RAR_RAR"; } }
        public string MessageStructureId { get { return @"RAR_RAR"; } }
        public string EventDescription { get { return @"Pharmacy Administration Information Response"; } }

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

        public HL7V22TriggerEventRAR_RAR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.err = new HL7V22SegmentERR(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
