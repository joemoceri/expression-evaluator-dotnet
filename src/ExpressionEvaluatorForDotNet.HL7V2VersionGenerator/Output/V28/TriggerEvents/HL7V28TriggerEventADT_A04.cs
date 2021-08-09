using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventADT_A04
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentEVN evn{ get; init; }
public HL7V28SegmentPID pid{ get; init; }
public HL7V28SegmentPD1 pd1{ get; init; }
public HL7V28SegmentARV arv{ get; init; }
public HL7V28SegmentROL rol{ get; init; }
public HL7V28SegmentNK1 nk1{ get; init; }
public HL7V28SegmentPV1 pv1{ get; init; }
public HL7V28SegmentPV2 pv2{ get; init; }
public HL7V28SegmentARV arv{ get; init; }
public HL7V28SegmentROL rol{ get; init; }
public HL7V28SegmentDB1 db1{ get; init; }
public HL7V28SegmentOBX obx{ get; init; }
public HL7V28SegmentAL1 al1{ get; init; }
public HL7V28SegmentDG1 dg1{ get; init; }
public HL7V28SegmentDRG drg{ get; init; }
public HL7V28SegmentGT1 gt1{ get; init; }
public HL7V28SegmentACC acc{ get; init; }
public HL7V28SegmentUB1 ub1{ get; init; }
public HL7V28SegmentUB2 ub2{ get; init; }
public HL7V28SegmentPDA pda{ get; init; }


        public string Id { get { return @"ADT_A04"; } }
        public string MessageStructureId { get { return @"ADT_A04"; } }
        public string EventDescription { get { return @"Register a patient"; } }

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

        public HL7V28TriggerEventADT_A04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.pd1 = new HL7V28SegmentPD1(this.message);
this.arv = new HL7V28SegmentARV(this.message);
this.rol = new HL7V28SegmentROL(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.pv1 = new HL7V28SegmentPV1(this.message);
this.pv2 = new HL7V28SegmentPV2(this.message);
this.arv = new HL7V28SegmentARV(this.message);
this.rol = new HL7V28SegmentROL(this.message);
this.db1 = new HL7V28SegmentDB1(this.message);
this.obx = new HL7V28SegmentOBX(this.message);
this.al1 = new HL7V28SegmentAL1(this.message);
this.dg1 = new HL7V28SegmentDG1(this.message);
this.drg = new HL7V28SegmentDRG(this.message);
this.gt1 = new HL7V28SegmentGT1(this.message);
this.acc = new HL7V28SegmentACC(this.message);
this.ub1 = new HL7V28SegmentUB1(this.message);
this.ub2 = new HL7V28SegmentUB2(this.message);
this.pda = new HL7V28SegmentPDA(this.message);

        }
    }
}
