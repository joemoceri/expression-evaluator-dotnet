using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventQRY_T12
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentQRD qrd{ get; init; }
public HL7V251SegmentQRF qrf{ get; init; }


        public string Id { get { return @"QRY_T12"; } }
        public string MessageStructureId { get { return @"QRY_T12"; } }
        public string EventDescription { get { return @"Document Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V251TriggerEventQRY_T12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);

        }
    }
}
