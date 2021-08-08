using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventADT_A55
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentEVN evn;
public readonly HL7V26SegmentPID pid;
public readonly HL7V26SegmentPD1 pd1;
public readonly HL7V26SegmentROL rol;
public readonly HL7V26SegmentPV1 pv1;
public readonly HL7V26SegmentPV2 pv2;
public readonly HL7V26SegmentROL rol;


        public string Id { get { return @"ADT_A55"; } }
        public string MessageStructureId { get { return @"ADT_A55"; } }
        public string EventDescription { get { return @"Cancel Change Attending Doctor"; } }

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

        public HL7V26TriggerEventADT_A55(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pd1 = new HL7V26SegmentPD1(this.message);
this.rol = new HL7V26SegmentROL(this.message);
this.pv1 = new HL7V26SegmentPV1(this.message);
this.pv2 = new HL7V26SegmentPV2(this.message);
this.rol = new HL7V26SegmentROL(this.message);

        }
    }
}