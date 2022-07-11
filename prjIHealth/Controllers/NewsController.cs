using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class NewsController : Controller
    {
        private IWebHostEnvironment _enviroment;
        public NewsController(IWebHostEnvironment n)
        {
            _enviroment = n;
        }
        IHealthContext db = new IHealthContext();

        int pageBlogSize = 6;
        int pageListSize = 3;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog(CKeywordViewModel vModel)
        {
            //IHealthyContext db = new IHealthyContext();
            IEnumerable<TNews> datas = null;
            if (string.IsNullOrEmpty(vModel.txtKeyword))
            {
                datas = from t in db.TNews
                        select t;
            }
            else
            {
                datas = db.TNews.Where(t => t.FTitle.Contains(vModel.txtKeyword));
            }
            return View(datas);
        }

        public IActionResult BlogDetail(int? id)
        {
            TNews news = db.TNews.FirstOrDefault(t => t.FNewsId == id);
            if (news == null)
                return RedirectToAction("Blog");
            return View(news);
        }
    }
}
