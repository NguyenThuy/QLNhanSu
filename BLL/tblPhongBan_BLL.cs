using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class tblPhongBan_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public List<tblPhongBan> SelectAll()
        {
            return DB.tblPhongBans.ToList();
        }
        public tblPhongBan FindID(string ID)
        {
            return DB.tblPhongBans.Where(pb => pb.MaPhong == ID).FirstOrDefault();
        }

        public void DeleteID(string ID)
        {
            tblPhongBan pb = FindID(ID);
            DB.tblPhongBans.DeleteOnSubmit(pb);
            DB.SubmitChanges();
        }
        public void Add(tblPhongBan pb)
        {
            DB.tblPhongBans.InsertOnSubmit(pb);
            DB.SubmitChanges();
        }
    }
}
