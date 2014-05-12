using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class tblChucVu_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public List<tblChucVu> SelectAll()
        {
            return DB.tblChucVus.ToList();
        }

        public tblChucVu FindID(string ID)
        {
            return DB.tblChucVus.Where(nv1 => nv1.MaCV == ID).FirstOrDefault();
        }

        public void DeleteID(string ID)
        {
            tblChucVu cv = FindID(ID);
            if (cv != null)
            {
                DB.tblChucVus.DeleteOnSubmit(cv);
            }
            DB.SubmitChanges();
        }

        public void Add(tblChucVu nv)
        {
            DB.tblChucVus.InsertOnSubmit(nv);
            DB.SubmitChanges();
        }
    }
}
