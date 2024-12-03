using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using student_Management.Data;
using student_Management.Models;

namespace student_Management.Controllers
{
    public class TranscriptsController : Controller
    {
        private student_ManagementContext db = new student_ManagementContext();

        // GET: Transcripts
        public ActionResult Index()
        {
            var transcripts = db.Transcripts.Include(t => t.Student);
            return View(transcripts.ToList());
        }

        // GET: Transcripts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transcript transcript = db.Transcripts.Find(id);
            if (transcript == null)
            {
                return HttpNotFound();
            }
            return View(transcript);
        }

        // GET: Transcripts/Create
        public ActionResult Create()
        {
            ViewBag.student_id = new SelectList(db.Students, "student_id", "first_name");
            return View();
        }

        // POST: Transcripts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "transcript_id,student_id,generated_date")] Transcript transcript)
        {
            if (ModelState.IsValid)
            {
                db.Transcripts.Add(transcript);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.student_id = new SelectList(db.Students, "student_id", "first_name", transcript.student_id);
            return View(transcript);
        }

        // GET: Transcripts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transcript transcript = db.Transcripts.Find(id);
            if (transcript == null)
            {
                return HttpNotFound();
            }
            ViewBag.student_id = new SelectList(db.Students, "student_id", "first_name", transcript.student_id);
            return View(transcript);
        }

        // POST: Transcripts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "transcript_id,student_id,generated_date")] Transcript transcript)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transcript).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.student_id = new SelectList(db.Students, "student_id", "first_name", transcript.student_id);
            return View(transcript);
        }

        // GET: Transcripts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transcript transcript = db.Transcripts.Find(id);
            if (transcript == null)
            {
                return HttpNotFound();
            }
            return View(transcript);
        }

        // POST: Transcripts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transcript transcript = db.Transcripts.Find(id);
            db.Transcripts.Remove(transcript);
            db.SaveChanges();
            return RedirectToAction("Index");
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
