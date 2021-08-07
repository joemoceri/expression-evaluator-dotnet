using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRQI_I02
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentPID pid;
public readonly HL7V25SegmentNK1 nk1;
public readonly HL7V25SegmentNTE nte;


        public string Id { get { return @"RQI_I02"; } }
        public string MessageStructureId { get { return @"RQI_I02"; } }
        public string EventDescription { get { return @"Request/receipt of patient selection display list"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
                    };
            }
        }

        public HL7V25TriggerEventRQI_I02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.nk1 = new HL7V25SegmentNK1(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
