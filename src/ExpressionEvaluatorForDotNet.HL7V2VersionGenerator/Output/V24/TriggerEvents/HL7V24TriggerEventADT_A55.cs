using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventADT_A55
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentEVN evn;
public readonly HL7V24SegmentPID pid;
public readonly HL7V24SegmentPD1 pd1;
public readonly HL7V24SegmentPV1 pv1;
public readonly HL7V24SegmentPV2 pv2;


        public string Id { get { return @"ADT_A55"; } }
        public string MessageStructureId { get { return @"ADT_A55"; } }
        public string EventDescription { get { return @"Cancel change attending doctor"; } }

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

        public HL7V24TriggerEventADT_A55(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.pv1 = new HL7V24SegmentPV1(this.message);
this.pv2 = new HL7V24SegmentPV2(this.message);

        }
    }
}
