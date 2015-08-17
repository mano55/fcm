using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fcm
{
    public class CTeam
    {
        private bool playerExists(UInt32 id) 
        {
            return (Players.Find(p => p.ID == id)!= null);
        }
        public CTeam(string name)
        {
            Name = name;

            Players = new List<CPlayer>(); ;
            Manager = new CPerson("aaa", "sss", 0);
            Coach = new CPerson("zzz", "xxx", 0);
            Schedule = new CTrainingSchedule();

        }
        public CTeam()
        {
            Players = new List<CPlayer>(); ;
            Schedule = new CTrainingSchedule();

        }

        public string addPlayer(string firstName, string lastName, UInt32 id,CCommunicationDetails commDet)
        {
            string res="";
            if (!playerExists(id))
            {
                Players.Add(new CPlayer(firstName, lastName, id, commDet));

            }
            else 
            {
                res += "שחקן בעל ת.ז זהה קיים במערכת \n";

            }
            return res;
        }

        public void addPlayer(CPlayer player)
        {
            //adds the player at the head of the list
            Players.Insert(0,player);
        }

        public CPlayer getPlayer(UInt32 id) 
        {
            foreach (CPlayer p in Players) 
            {
                if(p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }

        public bool removePlayer(CPlayer player)
        {
            return Players.Remove(player);
        }

        public string DisplayTeam 
        { 
            get
            {
                string str ="\nמנהל : \n";
                str += "\n"+Manager.DisplayName + "\n";
                str += "\nמאמן : \n";
                str += "\n" + Coach.DisplayName + "\n";
                str += "\n" + "שחקנים : \n";

                
                foreach (CPlayer p in Players)
                {
                    str += p.DisplayName + "\n";
                }
                return str ;

            }
        }

        public string Name { get; set; }
        public CPerson Manager { set; get; }
        public CPerson Coach { set; get; }
        public List<CPlayer> Players{get; set; }
        public CTrainingSchedule Schedule { set; get; }
    }
}
