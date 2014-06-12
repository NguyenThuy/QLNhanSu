using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class tblUser_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();

        public List<tblUser> SelectAll()
        {
            return DB.tblUsers.ToList();
        }

        public tblUser FindUser(string User)
        {
            return DB.tblUsers.Where(user => user.UserName == User).FirstOrDefault();
        }
        public void DeleteUser(string User)
        {
            tblUser user = new tblUser();
            user = DB.tblUsers.Where(user1 => user1.UserName == User).FirstOrDefault();
            if(user!=null)
            {
                DB.tblUsers.DeleteOnSubmit(user);
            }
            DB.SubmitChanges();
        }
    }
}
