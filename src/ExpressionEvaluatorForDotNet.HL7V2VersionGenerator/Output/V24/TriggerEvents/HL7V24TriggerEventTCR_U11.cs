using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventTCR_U11
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentEQU equ{ get; init; }
public HL7V24SegmentTCC tcc{ get; init; }
public HL7V24SegmentROL rol{ get; init; }


        public string Id { get { return @"TCR_U11"; } }
        public string MessageStructureId { get { return @"TCR_U11"; } }
        public string EventDescription { get { return @"Automated equipment test code settings request"; } }

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

        public HL7V24TriggerEventTCR_U11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.tcc = new HL7V24SegmentTCC(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
