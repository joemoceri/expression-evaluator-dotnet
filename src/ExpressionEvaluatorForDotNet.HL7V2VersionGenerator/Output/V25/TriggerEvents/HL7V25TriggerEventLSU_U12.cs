using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventLSU_U12
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentEQU equ;
public readonly HL7V25SegmentEQP eqp;
public readonly HL7V25SegmentROL rol;


        public string Id { get { return @"LSU_U12"; } }
        public string MessageStructureId { get { return @"LSU_U12"; } }
        public string EventDescription { get { return @"Automated equipment log/service update"; } }

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

        public HL7V25TriggerEventLSU_U12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.equ = new HL7V25SegmentEQU(this.message);
this.eqp = new HL7V25SegmentEQP(this.message);
this.rol = new HL7V25SegmentROL(this.message);

        }
    }
}