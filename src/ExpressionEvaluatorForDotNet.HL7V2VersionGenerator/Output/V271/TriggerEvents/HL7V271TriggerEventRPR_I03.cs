using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRPR_I03
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentMSA msa{ get; init; }
public HL7V271SegmentPID pid{ get; init; }
public HL7V271SegmentNTE nte{ get; init; }


        public string Id { get { return @"RPR_I03"; } }
        public string MessageStructureId { get { return @"RPR_I03"; } }
        public string EventDescription { get { return @"Return Patient List"; } }

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

        public HL7V271TriggerEventRPR_I03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
