using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSSU_U03
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentEQU equ;
public readonly HL7V27SegmentROL rol;


        public string Id { get { return @"SSU_U03"; } }
        public string MessageStructureId { get { return @"SSU_U03"; } }
        public string EventDescription { get { return @"Specimen status update"; } }

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

        public HL7V27TriggerEventSSU_U03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.equ = new HL7V27SegmentEQU(this.message);
this.rol = new HL7V27SegmentROL(this.message);

        }
    }
}