using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRAS_O17
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentNTE nte{ get; init; }


        public string Id { get { return @"RAS_O17"; } }
        public string MessageStructureId { get { return @"RAS_O17"; } }
        public string EventDescription { get { return @"Pharmacy/treatment administration"; } }

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

        public HL7V24TriggerEventRAS_O17(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
