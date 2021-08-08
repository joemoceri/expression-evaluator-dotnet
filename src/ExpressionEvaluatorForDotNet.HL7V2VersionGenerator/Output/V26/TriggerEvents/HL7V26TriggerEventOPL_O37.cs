using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventOPL_O37
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentNTE nte;
public readonly HL7V26SegmentROL rol;


        public string Id { get { return @"OPL_O37"; } }
        public string MessageStructureId { get { return @"OPL_O37"; } }
        public string EventDescription { get { return @"Population/Location-Based Laboratory Order"; } }

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

        public HL7V26TriggerEventOPL_O37(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.nte = new HL7V26SegmentNTE(this.message);
this.rol = new HL7V26SegmentROL(this.message);

        }
    }
}