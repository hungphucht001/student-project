using DT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DT.Controllers
{
    public class HomeAPIController : ApiController
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET api/<controller>
        public List<tb_SanPham> GetPhone()
        {
            return db.tb_SanPham.Where(x => x.MaDanhMuc == 1).OrderBy(x => x.ID).Skip(0).Take(8).ToList();
        }
        public IEnumerable<tb_SanPham> GetAccessory()
        {
            return db.tb_SanPham.Where(x => x.MaDanhMuc == 2).OrderBy(x => x.ID).Skip(0).Take(8);
        }

       
        // GET api/<controller>/5
        public tb_SanPham Get(int id)
        {
            return db.tb_SanPham.FirstOrDefault(t => t.ID == id);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}