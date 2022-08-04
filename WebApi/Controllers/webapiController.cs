using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DummyMVC.Models;
using DummyMVC.Data;

namespace WebApi.Controllers
{
    public class webapiController : ApiController
    {
        //public string getA ()
        // {
        //     return "rfvdfv";
        // }

        public List<SearLinqModel> GetSearchList()
        {
            mvcdemoEntities db = new mvcdemoEntities();
            List<SearLinqModel> str = new List<SearLinqModel>();
            var RegistrationList = db.tblSearches.ToList();
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
