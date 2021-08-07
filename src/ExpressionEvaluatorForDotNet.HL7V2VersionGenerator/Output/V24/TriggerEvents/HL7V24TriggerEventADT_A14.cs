using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventADT_A14
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentEVN evn;
public readonly HL7V24SegmentPID pid;
public readonly HL7V24SegmentPD1 pd1;
public readonly HL7V24SegmentROL rol;
public readonly HL7V24SegmentNK1 nk1;
public readonly HL7V24SegmentPV1 pv1;
public readonly HL7V24SegmentPV2 pv2;
public readonly HL7V24SegmentROL rol;
public readonly HL7V24SegmentDB1 db1;
public readonly HL7V24SegmentOBX obx;
public readonly HL7V24SegmentAL1 al1;
public readonly HL7V24SegmentDG1 dg1;
public readonly HL7V24SegmentDRG drg;
public readonly HL7V24SegmentGT1 gt1;
public readonly HL7V24SegmentACC acc;
public readonly HL7V24SegmentUB1 ub1;
public readonly HL7V24SegmentUB2 ub2;


        public string Id { get { return @"ADT_A14"; } }
        public string MessageStructureId { get { return @"ADT_A14"; } }
        public string EventDescription { get { return @"Pending admit"; } }

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

        public HL7V24TriggerEventADT_A14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.rol = new HL7V24SegmentROL(this.message);
this.nk1 = new HL7V24SegmentNK1(this.message);
this.pv1 = new HL7V24SegmentPV1(this.message);
this.pv2 = new HL7V24SegmentPV2(this.message);
this.rol = new HL7V24SegmentROL(this.message);
this.db1 = new HL7V24SegmentDB1(this.message);
this.obx = new HL7V24SegmentOBX(this.message);
this.al1 = new HL7V24SegmentAL1(this.message);
this.dg1 = new HL7V24SegmentDG1(this.message);
this.drg = new HL7V24SegmentDRG(this.message);
this.gt1 = new HL7V24SegmentGT1(this.message);
this.acc = new HL7V24SegmentACC(this.message);
this.ub1 = new HL7V24SegmentUB1(this.message);
this.ub2 = new HL7V24SegmentUB2(this.message);

        }
    }
}
