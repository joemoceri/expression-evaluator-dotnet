using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventQRY_PC4
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentQRD qrd{ get; init; }
public HL7V231SegmentQRF qrf{ get; init; }


        public string Id { get { return @"QRY_PC4"; } }
        public string MessageStructureId { get { return @"QRY_PC4"; } }
        public string EventDescription { get { return @"Problem query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V231TriggerEventQRY_PC4(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);

        }
    }
}
