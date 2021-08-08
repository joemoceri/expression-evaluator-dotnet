using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventADT_A14
    {
        public readonly HL7V2Message message;
        public readonly HL7V21SegmentMSH msh;
public readonly HL7V21SegmentEVN evn;
public readonly HL7V21SegmentPID pid;
public readonly HL7V21SegmentPD1 pd1;
public readonly HL7V21SegmentNK1 nk1;
public readonly HL7V21SegmentPV1 pv1;
public readonly HL7V21SegmentDG1 dg1;


        public string Id { get { return @"ADT_A14"; } }
        public string MessageStructureId { get { return @"ADT_A14"; } }
        public string EventDescription { get { return @"Pending Admit"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventADT_A14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.evn = new HL7V21SegmentEVN(this.message);
this.pid = new HL7V21SegmentPID(this.message);
this.pd1 = new HL7V21SegmentPD1(this.message);
this.nk1 = new HL7V21SegmentNK1(this.message);
this.pv1 = new HL7V21SegmentPV1(this.message);
this.dg1 = new HL7V21SegmentDG1(this.message);

        }
    }
}