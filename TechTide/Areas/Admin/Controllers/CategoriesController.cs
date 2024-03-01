using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMSArticle.ModelsLayer;
using CMSArticle.ServiceLayer;
using CMSArticle;
using CMSArticle.App_Start;
using TechTide.Views.ViewModels;

namespace TechTide.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private CmsContext db = new CmsContext();

        CategoryService _CategoryService;

        public CategoriesController()
        {
            _CategoryService = new CategoryService(db);
        }


        public ActionResult Index()
        {
            var categoryList = _CategoryService.GetAll().ToList();
            var categoryListViewModel = AutoMapperConfig.mapper.Map<List<Category>, List<CategoryViewModel>>(categoryList);
            return View(categoryListViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryId,Title,ImageName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _CategoryService.Add(category);
                _CategoryService.Save();
                return RedirectToAction("Index");
            }

            return View(category);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = _CategoryService.GetEntity(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }



        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = _CategoryService.GetEntity(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryId,Title,ImageName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _CategoryService.Update(category);
                _CategoryService.Save();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = _CategoryService.GetEntity(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = _CategoryService.GetEntity(id);
            _CategoryService.Delete(category);
            _CategoryService.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _CategoryService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
