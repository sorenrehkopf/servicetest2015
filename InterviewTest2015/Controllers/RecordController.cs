using MCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InterviewTest2015.Controllers
{
    public class RecordController : ApiController
    {

        public IHttpActionResult Get(int id)
        {
            try
            {
                RecordModel r = new RecordModel().FindById(id);
                if (r == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(r);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}