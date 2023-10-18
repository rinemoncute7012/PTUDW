using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using modelfirst.Models;

namespace modelfirst.Controllers
{
    public class PhongBansController : Controller
    {
        private Context db = new Context();

        // GET: PhongBans
        public async Task<ActionResult> Index()
        {
            return View(await db.PhongBans.ToListAsync());
        }

        // GET: PhongBans/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongBan phongBan = await db.PhongBans.FindAsync(id);
            if (phongBan == null)
            {
                return HttpNotFound();
            }
            return View(phongBan);
        }

        // GET: PhongBans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhongBans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "maphong,tenphong")] PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                db.PhongBans.Add(phongBan);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(phongBan);
        }

        // GET: PhongBans/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongBan phongBan = await db.PhongBans.FindAsync(id);
            if (phongBan == null)
            {
                return HttpNotFound();
            }
            return View(phongBan);
        }

        // POST: PhongBans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "maphong,tenphong")] PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phongBan).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(phongBan);
        }

        // GET: PhongBans/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongBan phongBan = await db.PhongBans.FindAsync(id);
            if (phongBan == null)
            {
                return HttpNotFound();
            }
            return View(phongBan);
        }

        // POST: PhongBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            PhongBan phongBan = await db.PhongBans.FindAsync(id);
            db.PhongBans.Remove(phongBan);
            await db.SaveChangesAsync();
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
