using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRPI_I01
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentPID pid;
public readonly HL7V23SegmentNK1 nk1;
public readonly HL7V23SegmentNTE nte;


        public string Id { get { return @"RPI_I01"; } }
        public string MessageStructureId { get { return @"RPI_I01"; } }
        public string EventDescription { get { return @"Response for insurance information"; } }

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

        public HL7V23TriggerEventRPI_I01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.nk1 = new HL7V23SegmentNK1(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
