using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventPEX_P08
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentEVN evn{ get; init; }
public HL7V24SegmentPID pid{ get; init; }
public HL7V24SegmentPD1 pd1{ get; init; }
public HL7V24SegmentNTE nte{ get; init; }


        public string Id { get { return @"PEX_P08"; } }
        public string MessageStructureId { get { return @"PEX_P08"; } }
        public string EventDescription { get { return @"Unsolicited update individual product experience report"; } }

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

        public HL7V24TriggerEventPEX_P08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
