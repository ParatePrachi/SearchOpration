using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DummyMVC.Data;
using System.Data;
using System.Data.Common;
using System.Net;
using System.Text;
using System.Data.SqlClient;

namespace DummyMVC.Models
{
    public class SearchModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public Nullable<decimal> EmpSalary { get; set; }
        public string Job { get; set; }

        

        public List<SearchModel> GetEmpspList(string Empname)
        {
            mvcdemoEntities db = new mvcdemoEntities();
            List<SearchModel> str = new List<SearchModel>();
            DataTable dtTable = new DataTable();
            using (var cmd = db.Database.Connection.CreateCommand())
            {
                db.Database.Connection.Open();
                cmd.CommandText = "displayemp";
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataAdapter da = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateDataAdapter();

                DbParameter empname = cmd.CreateParameter();
                empname.ParameterName = "EmpName";
                empname.Value = Empname;
                cmd.Parameters.Add(empname);

                da.SelectCommand = cmd;
                da.Fill(dtTable);
                db.Database.Connection.Close();
            }
            foreach (DataRow dr in dtTable.Rows)
            {
                SearchModel blmodel = new SearchModel();
                //blmodel.EmpId = (Convert.ToInt32(dr["EmpId"]));
                blmodel.EmpName = (dr["EmpName"].ToString());
                //blmodel.EmpAddress = (dr["EmpAddress"].ToString());
                //blmodel.EmpSalary = (Convert.ToInt32(dr["EmpSalary"]));
                //blmodel.Job = (dr["Job"].ToString());

                str.Add(blmodel);
            }
            return str;
        }

    }
}