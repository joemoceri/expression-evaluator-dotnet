using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMDM_T11
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentEVN evn;
public readonly HL7V231SegmentPID pid;
public readonly HL7V231SegmentPV1 pv1;
public readonly HL7V231SegmentTXA txa;


        public string Id { get { return @"MDM_T11"; } }
        public string MessageStructureId { get { return @"MDM_T11"; } }
        public string EventDescription { get { return @"Document cancel notification"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
                    };
            }
        }

        public HL7V231TriggerEventMDM_T11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);
this.txa = new HL7V231SegmentTXA(this.message);

        }
    }
}
