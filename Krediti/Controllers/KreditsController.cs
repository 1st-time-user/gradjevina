using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Krediti.Models;

namespace Krediti.Controllers
{
    //public class CssViewResult : PartialViewResult
    //{
    //    public override void ExecuteResult(ControllerContext context)
    //    {
    //        context.HttpContext.Response.ContentType = "text/css";
    //        base.ExecuteResult(context);
    //    }
    //}
    public class KreditsController : Controller
    {
        private aktivnostidbContext db = new aktivnostidbContext();
        private ShowdbContext showDb = new ShowdbContext();
        private MBRDataDbContext dbMBR = new MBRDataDbContext();

        //public ActionResult Identifikacija()
        //{
        //    //var items = from p in db.MBRData
        //    //            where p.MBR == input
        //    //            select p;
        //    //Show model = new Show();
        //    //model.MBRDataList = new SelectList(db.MBRData, "MBR", "Naziv");
        //    //return View(model);
        //}
        public ActionResult Dalje()
        {
            return RedirectToAction("Identifikacija");
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kraj()
        {

            return View();
        }
        public ActionResult showTable()
        {
            //return new CssViewResult();
            return View(db.Aktivnosti.ToList());
        }
        public ActionResult Visible()
        {
            Aktivnosti pitanje = new Aktivnosti();
            //pitanje.Pitanje1;
            
            return View(db.Aktivnosti.ToList());
        }

        // GET: Kredits/Create
        public ActionResult Create() /*string mbr*/
        {
            Aktivnosti aktivnosti = new Aktivnosti();
            //aktivnosti.MBRData = new SelectList(dbMBR.MBRData, "MBRID", "Naziv");
            aktivnosti.MBRData = new SelectList(dbMBR.MBRData, "MBRID", "Naziv");
            return View(aktivnosti);
        }

        // POST: Kredits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Pitanje1,Pitanje2,Pitanje3,Pitanje4,Pitanje5,Pitanje6,Pitanje7,MBR,MBRID")] Aktivnosti aktivnosti)
        {
            if (ModelState.IsValid)
            {
                db.Aktivnosti.Add(aktivnosti);
                db.SaveChanges();
                return RedirectToAction("Kraj");
            }
            
            return View(aktivnosti);
        }

        // GET: Kredits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aktivnosti aktivnosti = db.Aktivnosti.Find(id);
            if (aktivnosti == null)
            {
                return HttpNotFound();
            }
            return View(aktivnosti);
        }

        // POST: Kredits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Pitanje1")] Aktivnosti aktivnosti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aktivnosti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aktivnosti);
        }

        // GET: Kredits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aktivnosti kredits = db.Aktivnosti.Find(id);
            if (kredits == null)
            {
                return HttpNotFound();
            }
            return View(kredits);
        }

        // POST: Kredits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aktivnosti kredits = db.Aktivnosti.Find(id);
            db.Aktivnosti.Remove(kredits);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Kredits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aktivnosti kredits = db.Aktivnosti.Find(id);
            if (kredits == null)
            {
                return HttpNotFound();
            }
            return View(kredits);
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
