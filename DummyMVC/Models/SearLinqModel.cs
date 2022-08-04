using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DummyMVC.Data;

namespace DummyMVC.Models
{
    public class SearLinqModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Emailid { get; set; }

        public List<SearLinqModel> GetSearchList(string Name)
        {
            mvcdemoEntities db = new mvcdemoEntities();
            List<SearLinqModel> str = new List<SearLinqModel>();
            var RegistrationList = db.tblSearches.Where(p => p.Name == Name).ToList();
            if (RegistrationList != null)
            {
                foreach (var reg in RegistrationList)
                {
                    str.Add(new SearLinqModel()
                    {
                        Id = reg.Id,
                        Name = reg.Name,
                        Address = reg.Address,
                        Emailid = reg.Emailid,

                    });
                }
            }
            return str;
        }


    }
}