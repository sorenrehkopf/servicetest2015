using MCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InterviewTest2015.Controllers
{
    public class RecordController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            return Ok(await RecordModel.WaitingForParts());
        }

        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                RecordModel r = await RecordModel.FindById(id);
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

        public async Task<IHttpActionResult> Put(RecordModel record)
        {
            if (await RecordModel.Update(record))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}