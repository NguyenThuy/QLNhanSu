using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class tblTrinhDo_BLL
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public List<tblTrinhDo> SelectAll()
        {
            return DB.tblTrinhDos.ToList();
        }
        public tblTrinhDo FindID(string ID)
        {
            return DB.tblTrinhDos.Where(td => td.MaTrinhDo == ID).FirstOrDefault();
        }
        public tblTrinhDo FindTen(string ten)
        {
            return DB.tblTrinhDos.Where(td => td.TenTrinhDo == ten).FirstOrDefault();
        }
        public void DeleteID(string ID)
        {
            tblTrinhDo td = FindID(ID);
            DB.tblTrinhDos.DeleteOnSubmit(td);
            DB.SubmitChanges();
        }
        public void Add(tblTrinhDo td)
        {
            DB.tblTrinhDos.InsertOnSubmit(td);
            DB.SubmitChanges();
        }
    }
}
