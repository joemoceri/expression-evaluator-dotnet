using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventADT_A40
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentEVN evn{ get; init; }


        public string Id { get { return @"ADT_A40"; } }
        public string MessageStructureId { get { return @"ADT_A40"; } }
        public string EventDescription { get { return @"Merge patient - patient identifier list"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V28TriggerEventADT_A40(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);

        }
    }
}
