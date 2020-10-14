using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class MakaleController : ApiController
    {
        private MakaleBLL makaleBLL = new MakaleBLL();

        // GET: api/Makale/GetAll
        public List<Makale> GetAll()
        {
            return makaleBLL.GetAll();
        }

        // GET: api/Makale/GetById
        public Makale GetById(int id)
        {
            return makaleBLL.GetById(id);
        }

        // POST: api/Makale/Insert
        public IHttpActionResult Insert(Makale makale)
        {
            try
            {
                makaleBLL.Insert(makale);
                return Ok(makale);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST: api/Makale/Update
        public IHttpActionResult Update(Makale makale)
        {
            try
            {
                makaleBLL.Update(makale);
                return Ok(makale);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST: api/Makale/Delete
        public IHttpActionResult Delete(Makale makale)
        {
            try
            {
                makaleBLL.Delete(makale);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
