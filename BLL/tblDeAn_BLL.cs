using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class tblDeAn_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public List<tblDeAn> SelectAll()
        {
            return DB.tblDeAns.ToList();
        }
        public tblDeAn FindID(string ID)
        {
            return DB.tblDeAns.Where(da => da.MaDA == ID).FirstOrDefault();
        }

        public void DeleteID(string ID)
        {
            tblDeAn da = FindID(ID);
            DB.tblDeAns.DeleteOnSubmit(da);
            DB.SubmitChanges();
        }
        public void Add(tblDeAn da)
        {
            DB.tblDeAns.InsertOnSubmit(da);
            DB.SubmitChanges();
        }
    }
}
