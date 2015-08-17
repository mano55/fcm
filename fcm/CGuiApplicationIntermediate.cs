using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO.IsolatedStorage;
using System.IO;

namespace fcm
{
    /*
     responsible for setaching the application layer from the user interface
     */

    class CGuiApplicationIntermediate
    {
        private static CUsers m_users;
        private static FormHome m_fHome;
        private static FormAdmin m_fAdmin;
        private static FormAddUser m_fAddUser;
        private static FormAddTeam m_fAddTeam;
        private static FormEditPlayersList m_fEditPlayerList;
        private static FormPlayer m_fPlayerDetailes;
        private static CTeamPool m_teams;
        private static volatile CGuiApplicationIntermediate instance;
        private static string teamsDBname;

         static CGuiApplicationIntermediate()
        {
            m_users = new CUsers();
            teamsDBname = @"D:\fcm\fcm\fcm\DataBase\teamsDB.xml";
        }

        public static CGuiApplicationIntermediate InstanceCreation()
        {
            if (instance == null)
            {
                instance = new CGuiApplicationIntermediate();
                m_fHome = new FormHome();
                m_fAdmin = new FormAdmin();
                m_fAddUser = new FormAddUser();
                m_fAddTeam = new FormAddTeam();
                m_fEditPlayerList = new FormEditPlayersList();
                m_fPlayerDetailes = new FormPlayer();
                m_teams = new CTeamPool();
                m_teams.Teams = loadTeamsDb();
            }
            return instance;
        }
        public bool logIn(string user, string password)
        {
            //TBD : RESTORE 
            //if (m_users.isAutorized(user,password))
            {
                return true;
            }
            return false;
        }
        public void showHomePage()
        {
            m_fHome.Show();
        }
        public void enterAdminSection(Form prev)
        {
            //TODO: have to check user previliges
            prev.Hide();
            m_fAdmin.Show();




        }
        public void exitAppliction()
        {
            System.Windows.Forms.Application.Exit();
        }
        public void addNewUer(string name, string password)
        {
            m_users.addNewUser(name, password);
        }
        public string addNewPlayer(string firstName, string lastName, UInt32 id, CCommunicationDetails commDet)
        {
             m_teams.getDefultTeam().addPlayer(new CPlayer(firstName, lastName, id, commDet));
            return "";//TBD have to check which test i missed

        }
        public bool addNemTeam(string teamName) 
        {
             return m_teams.addNewTeam(teamName);
        }
        public void openAddUserDialog()
        {
            m_fAddUser.Show();
        }
        public void openAddTeamDialog()
        {
            m_fAddTeam.Show();
        }
        public void openEditTeamPlayerList()
        {
            m_fEditPlayerList.Show();
        }
        public void openPlayerDetailesDialog()
        {
            m_fPlayerDetailes.Show();
        }
        public List<CTeam> getAllTeams()
        {
            return m_teams.getAllTeams();
        }
        public CTeam getTeam(string name) 
        {
            return m_teams.getTeam(name); 
        }
        public CTeam getDefultTeam() 
        {
            return m_teams.getDefultTeam();
        }
        public Dictionary<string, string> getUsers() { return m_users.kunownUsers; } 
        public static List<CTeam> loadTeamsDb()
        {
			var serializer = new XmlSerializer(typeof (List<CTeam>));
            using (var fs = new FileStream(teamsDBname, FileMode.Open))
			{
                return (List<CTeam>)serializer.Deserialize(fs);
			}
		}
        public void saveTeamsDb()
        {
            var serializer = new XmlSerializer(typeof(List<CTeam>));
            using (var fs = new FileStream(teamsDBname, FileMode.Open))
			{
                serializer.Serialize(fs, m_teams.Teams);
			}
        }
    }
}
