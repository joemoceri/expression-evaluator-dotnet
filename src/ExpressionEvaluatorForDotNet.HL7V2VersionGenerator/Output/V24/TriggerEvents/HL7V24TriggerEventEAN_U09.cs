using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventEAN_U09
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentEQU equ;
public readonly HL7V24SegmentROL rol;


        public string Id { get { return @"EAN_U09"; } }
        public string MessageStructureId { get { return @"EAN_U09"; } }
        public string EventDescription { get { return @"Automated equipment notification"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
                    };
            }
        }

        public HL7V24TriggerEventEAN_U09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}