using BitimeProjesi.Web.ViewModel;
using BitirmeProjem.BusinessLayer;
using BitirmeProjem.BusinessLayer.Test;
using BitirmeProjem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BitimeProjesi.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        PostManager post = new PostManager();
        public ActionResult Index()
        {
            ViewBag.GetPost = post.GetPost().OrderByDescending(x => x.ModifyTime).ToList();
            return View(ViewBag.GetPost);
        }
        public ActionResult GetTag(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TagManager tg = new TagManager();
            Tag tgm = tg.GetTag(id.Value);
            if (tgm ==null)
            {
                return HttpNotFound();
            }
            return View("Index", tgm.Posts.OrderByDescending(x => x.ModifyTime).ToList());
        }
        public ActionResult MostLike()
        {
            ViewBag.GetPost = post.GetPost().OrderByDescending(x => x.LikeCount).ToList();
            return View("Index", ViewBag.GetPost);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}