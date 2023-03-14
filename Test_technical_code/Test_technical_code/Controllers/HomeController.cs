using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Test_technical_code.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GenerateSegitiga(int paramValue)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var numb = paramValue.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            int colNumb = 1;

            for (int j = 0; j < numb.Length; j++)
            {
                stringBuilder.Append(numb[j]);
                for (int x = 0; x < colNumb; x++)
                {
                    stringBuilder.Append("0");
                }
                stringBuilder.AppendLine("");
                colNumb++;
            }

            return Json(stringBuilder, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GenerateBilanganPrima(int paramValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool checkPrime = true;

            if (paramValue >= 2)
            {
                for (int i = 2; i <= paramValue; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            checkPrime = false;
                            break;
                        }
                    }
                    if (checkPrime)
                    {
                        stringBuilder.Append(i.ToString());

                    }
                    checkPrime = true;
                }
            }
            else
            {
                stringBuilder.Append("No Prime");
            }
            return Json(stringBuilder, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GenerateBilanganGanjil(int paramValue)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (paramValue > 0)
            {
                for (int j = 1; j <= paramValue; j++)
                {
                    if (j % 2 != 0)
                    {
                        stringBuilder.Append(j.ToString());
                    }
                }

            }
            else
            {
                stringBuilder.Append("Input mu be greater than zero!");
            }


            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}