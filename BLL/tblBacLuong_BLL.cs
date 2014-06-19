using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class tblBacLuong_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        //chú thích 
        public List<tblBacLuong> SelectAll()
        {
            return DB.tblBacLuongs.ToList();
        }
        public tblBacLuong FindID(string ID)
        {
            return DB.tblBacLuongs.Where(bl => bl.MaBacLuong == ID).FirstOrDefault();
        }

        public void DeleteID(string ID)
        {
            tblBacLuong bl = FindID(ID);
            DB.tblBacLuongs.DeleteOnSubmit(bl);
            DB.SubmitChanges();
        }
        public void Add(tblBacLuong bl)
        {
            DB.tblBacLuongs.InsertOnSubmit(bl);
            DB.SubmitChanges();
        }
    }
}
