using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class tblNhanVien_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public List<tblNhanVien> SelectAll()
        {
            return DB.tblNhanViens.ToList();
        }

        public List<tblNhanVien> SelectIDPhong(string ID)
        {
            return DB.tblNhanViens.Where(nv => nv.MaPhong == ID).ToList();
        }

        public List<tblNhanVien> SelectIDChucVu(string ID)
        {
            return DB.tblNhanViens.Where(nv => nv.MaCV == ID).ToList();
        }
        public List<tblNhanVien> SelectIDBacLuong(string ID)
        {
            return DB.tblNhanViens.Where(nv => nv.MaBacLuong == ID).ToList();
        }

        public tblNhanVien FindID(string MaNV)
        {
            return DB.tblNhanViens.Where(nv1 => nv1.MaNV == MaNV).FirstOrDefault();
        }

        public void DeleteID(string MaNV)
        {
            tblNhanVien nv = FindID(MaNV);
            if(nv!=null)
            {
                DB.tblNhanViens.DeleteOnSubmit(nv);
            }
            DB.SubmitChanges();
        }

        public void AddNV(tblNhanVien nv)
        {
            DB.tblNhanViens.InsertOnSubmit(nv);
            DB.SubmitChanges();
        }
    }
}
