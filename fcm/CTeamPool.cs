using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fcm
{
    public class CTeamPool
    {
        public List<CTeam> Teams{get; set;}
        
        private bool teamExists(string name) 
        {
            bool res = false;
            foreach (var t in Teams)
            {
                if (t.Name.Equals(name))
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        /*
         * creates the teams pool and creates a defualt team
         */
        public CTeamPool() 
        {
            Teams = new List<CTeam>(); 
            Teams.Add(new CTeam("שחקנים שאינם משוייכים לקבוצה"));
        }
        /********************************************************
         * returns false if team with the same name alredy exists       
         * otherwise adds new team to the list and returns true
         *******************************************************/
        public bool addNewTeam(string name)
        {
            bool res = teamExists(name);
            if (!res) 
            {
                Teams.Add(new CTeam(name));
            }            
            return !res;
        }
        public List<CTeam> getAllTeams() 
        { 
            return Teams; 
        }
       /*
        *  returns CTeam by name if exists, Null othewise 
        */
        public CTeam getTeam(string name)
        {
            return Teams.Find(t => t.Name == name);
        }
        public CTeam getDefultTeam()
        {
            return Teams.Find(t => t.Name == "שחקנים שאינם משוייכים לקבוצה");
        }
    }
}
