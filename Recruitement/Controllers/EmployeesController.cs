using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Recruitement.Models;

namespace Recruitement.Controllers
{
    public class EmployeesController : ApiController
    {
        RecruitementEntities db = new RecruitementEntities();

        // GET api/values
        public IEnumerable<Danh_Sach_Ung_Cu> Get()
        {
            IList<Danh_Sach_Ung_Cu> ds = new List<Danh_Sach_Ung_Cu>();
            var list = db.Danh_Sach_Ung_Cu.ToList();
            foreach (var item in list)
            {
                ds.Add(new Danh_Sach_Ung_Cu
                {
                    ID = item.ID,
                    Name = item.Name
                });
            }
            return ds;
        }

        public IEnumerable<Danh_Sach_Ung_Cu> getid(string id)
        {
            var ma = int.Parse(id);
            IList<Danh_Sach_Ung_Cu> ds = new List<Danh_Sach_Ung_Cu>();
            var list = db.Danh_Sach_Ung_Cu.Where(x => x.ID == ma).ToList();
            foreach (var item in list)
            {
                ds.Add(new Danh_Sach_Ung_Cu
                {
                    ID = item.ID,
                    Name = item.Name
                });
            }
            return ds;
        }
    }
}
