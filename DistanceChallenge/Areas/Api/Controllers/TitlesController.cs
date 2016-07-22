using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DistanceChallenge.Data;

namespace DistanceChallenge.Areas.Api.Controllers
{
    public class TitlesController : ApiController
    {
        private TitlesEntities1 db = new TitlesEntities1();

        // GET: api/Titles
        public IQueryable<Models.TitleModel> GetTitles()
        {
            return db.Titles.ToList().Select(t => new Models.TitleModel(t)).AsQueryable();
        }

        // GET: api/Titles/5
        [ResponseType(typeof(Models.TitleModel))]
        public IHttpActionResult GetTitle(int id)
        {
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                return NotFound();
            }

            return Ok(new Models.TitleModel(title));
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}