using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fcm
{
    class CUsers
    {
        public Dictionary<string, string> kunownUsers{set;get;}
        public CUsers()
         {
             kunownUsers = new Dictionary<string, string>();
             kunownUsers.Add("admin", "admin");
         }
        public Boolean isAutorized(string user, string password)
         {
             Boolean res = false;
             
             if (kunownUsers.ContainsKey(user))
                { 
                    if(kunownUsers[user]==password)
                    {
                       res = true;
                    }
                    else
                    {
                        MessageBox.Show("סיסמא שגויה,נסה שוב"); 
                        res = false;
                    }
                }
             else
             {
                 MessageBox.Show("משתמש לא מוכר");
                 res = false;
             
             }
             return res;
         }
        public void addNewUser(string user, string password)
        {
            if (kunownUsers.ContainsKey(user))
            {
                MessageBox.Show("משתמש קיים");
            }
            else 
            {
                MessageBox.Show("משתמש " + user + " נוסף בהצלחה");
                kunownUsers.Add(user, password);
            }
            
        
        }
    }
}
