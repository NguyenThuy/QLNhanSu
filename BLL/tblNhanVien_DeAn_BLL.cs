using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class tblNhanVien_DeAn_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public List<tblNhanVien_DeAn> SelectAll()
        {
            return DB.tblNhanVien_DeAns.ToList();
        }
        public tblNhanVien_DeAn FindID(string ID)
        {
            return DB.tblNhanVien_DeAns.Where(da => da.MaDA == ID).FirstOrDefault();
        }

        public void DeleteID(string ID)
        {
            tblNhanVien_DeAn da = FindID(ID);
            DB.tblNhanVien_DeAns.DeleteOnSubmit(da);
            DB.SubmitChanges();
        }
        public void Add(tblNhanVien_DeAn da)
        {
            DB.tblNhanVien_DeAns.InsertOnSubmit(da);
            DB.SubmitChanges();
        }
    }
}
