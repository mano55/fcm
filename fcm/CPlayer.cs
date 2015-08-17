using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fcm
{
    public class CPlayer:CPerson
    {
        public CPlayer(){ }
        public CPlayer(string firstName, string lastName, UInt32 ID) :base(firstName, lastName,ID)  {}
        public CPlayer(string firstName, string lastName, UInt32 id, CCommunicationDetails commDet) : base(firstName, lastName, id, commDet) { }
        public string DominantLeg { set; get; }
    }
}
