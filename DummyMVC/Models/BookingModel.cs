using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using DummyMVC.Data;
using System.Xml.Linq;

namespace DummyMVC.Models
{
    public class BookingModel
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string MobileNo { get; set; }

        public  List<BookingModel> getspjoin()
        {
            mvcdemoEntities db = new mvcdemoEntities();
            List<BookingModel> lstspjoin = new List<BookingModel>();
            DataTable dttable = new DataTable();
            using (var cmd = db.Database.Connection.CreateCommand())
            {
                db.Database.Connection.Open();
                cmd.CommandText = "EmpjoinBook";
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataAdapter da = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(dttable);
                db.Database.Connection.Close();
            }
            foreach(DataRow dr in dttable.Rows)
            {
                BookingModel blmodel = new BookingModel();
                blmodel.EmpId = Convert.ToInt32(dr["EmpId"].ToString());
                blmodel.EmpName = (dr["EmpName"].ToString());
                blmodel.Name = (dr["Name"].ToString());
                blmodel.Address = (dr["Address"].ToString());

                lstspjoin.Add(blmodel);
            }
            return lstspjoin;
        }

        public List<BookingModel> usinglinqjoin ()
        {
            mvcdemoEntities db = new mvcdemoEntities();
            List<BookingModel> lstbook = new List<BookingModel>();
            var linqlist = from book in db.tblBookings
                           join emp in db.tblBookings on book.BookingId equals emp.BookingId
                           select new
                           {
                               book.BookingId,
                               emp.Name,
                               book.EmpId,
                               book.MobileNo
                           };
            if(linqlist!= null)
            {
                foreach(var addbook in linqlist)
                {
                    lstbook.Add(new BookingModel()
                    {
                        BookingId = addbook.BookingId,
                        Name = addbook.Name,
                        EmpId = addbook.EmpId,
                        MobileNo = addbook.MobileNo,
                    });
                }
            }
            return lstbook;
        }
    }
}