using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A44
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentEVN evn;


        public string Id { get { return @"ADT_A44"; } }
        public string MessageStructureId { get { return @"ADT_A44"; } }
        public string EventDescription { get { return @"Move Account Information - Patient Account Number"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
                    };
            }
        }

        public HL7V251TriggerEventADT_A44(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);

        }
    }
}