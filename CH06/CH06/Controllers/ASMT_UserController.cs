using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CH06.Models;

namespace CH06.Controllers
{
    public class ASMT_UserController : Controller
    {
        private asmedia_testEntities db = new asmedia_testEntities();

        // GET: ASMT_User
        public ActionResult Index()
        {
            
            ViewBag.AAA = "CCC";
            return View(db.ASMT_User.ToList());
        }


        public ActionResult DataList()
        {

            ViewBag.AAA = "BBB";
            ViewBag.DataList = db.ASMT_User.ToList();
            return View(db.ASMT_User.ToList());
        }


        public ActionResult CheckInput(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                TempData["Error"] = "MUST INPUT DATA!!";
                return RedirectToAction("DataList");
            }

            ViewBag.Name = name;
            return View();

        }



        // GET: ASMT_User/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASMT_User aSMT_User = db.ASMT_User.Find(id);
            if (aSMT_User == null)
            {
                return HttpNotFound();
            }
            return View(aSMT_User);
        }

        // GET: ASMT_User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASMT_User/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserEmpID,UserID,UserName,DeptID,DeptName,ExtNumber,Email,OnBoardDate,JobTitle,Manager_lv01,Role,OnJob,UpdTime")] ASMT_User aSMT_User)
        {
            if (ModelState.IsValid)
            {
                db.ASMT_User.Add(aSMT_User);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aSMT_User);
        }

        // GET: ASMT_User/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASMT_User aSMT_User = db.ASMT_User.Find(id);
            if (aSMT_User == null)
            {
                return HttpNotFound();
            }
            return View(aSMT_User);
        }

        // POST: ASMT_User/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserEmpID,UserID,UserName,DeptID,DeptName,ExtNumber,Email,OnBoardDate,JobTitle,Manager_lv01,Role,OnJob,UpdTime")] ASMT_User aSMT_User)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aSMT_User).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aSMT_User);
        }

        // GET: ASMT_User/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASMT_User aSMT_User = db.ASMT_User.Find(id);
            if (aSMT_User == null)
            {
                return HttpNotFound();
            }
            return View(aSMT_User);
        }

        // POST: ASMT_User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ASMT_User aSMT_User = db.ASMT_User.Find(id);
            db.ASMT_User.Remove(aSMT_User);
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
