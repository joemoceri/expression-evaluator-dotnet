using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventORU_W01
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"ORU_W01"; } }
        public string MessageStructureId { get { return @"ORU_W01"; } }
        public string EventDescription { get { return @"Waveform result, unsolicited transmission of requested information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
                    };
            }
        }

        public HL7V231TriggerEventORU_W01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
