using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventPMU_B04
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentEVN evn;
public readonly HL7V251SegmentSTF stf;
public readonly HL7V251SegmentPRA pra;
public readonly HL7V251SegmentORG org;


        public string Id { get { return @"PMU_B04"; } }
        public string MessageStructureId { get { return @"PMU_B04"; } }
        public string EventDescription { get { return @"Active practicing person"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
                    };
            }
        }

        public HL7V251TriggerEventPMU_B04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.stf = new HL7V251SegmentSTF(this.message);
this.pra = new HL7V251SegmentPRA(this.message);
this.org = new HL7V251SegmentORG(this.message);

        }
    }
}