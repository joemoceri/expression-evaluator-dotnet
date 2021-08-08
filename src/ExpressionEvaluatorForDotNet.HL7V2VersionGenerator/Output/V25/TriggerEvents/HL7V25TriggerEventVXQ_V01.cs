using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventVXQ_V01
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentQRD qrd;
public readonly HL7V25SegmentQRF qrf;


        public string Id { get { return @"VXQ_V01"; } }
        public string MessageStructureId { get { return @"VXQ_V01"; } }
        public string EventDescription { get { return @"Vaccination Record Query"; } }

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

        public HL7V25TriggerEventVXQ_V01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);

        }
    }
}