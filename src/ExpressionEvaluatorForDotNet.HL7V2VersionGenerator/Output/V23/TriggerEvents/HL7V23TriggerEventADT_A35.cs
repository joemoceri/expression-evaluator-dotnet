using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventADT_A35
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentEVN evn{ get; init; }
public HL7V23SegmentPID pid{ get; init; }
public HL7V23SegmentPD1 pd1{ get; init; }
public HL7V23SegmentMRG mrg{ get; init; }


        public string Id { get { return @"ADT_A35"; } }
        public string MessageStructureId { get { return @"ADT_A35"; } }
        public string EventDescription { get { return @"Merge patient information - account number only"; } }

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

        public HL7V23TriggerEventADT_A35(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.evn = new HL7V23SegmentEVN(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.pd1 = new HL7V23SegmentPD1(this.message);
this.mrg = new HL7V23SegmentMRG(this.message);

        }
    }
}
