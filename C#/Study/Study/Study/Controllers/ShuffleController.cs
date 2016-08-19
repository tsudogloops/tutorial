using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Study.Models;

namespace Study.Controllers
{
    public class ShuffleController : Controller
    {
        // GET: Shuffle
        public ActionResult Index()
        {
            //return "Hello World...";
            return View();
        }

        public ActionResult Shuffle()
        {
            return View(new ShuffleViewModel()
            {
                Registers = ShuffleRegisters
            });
        }

        public static HashSet<string> ShuffleRegisters = new HashSet<string>()
        {
            "toida",
            "saito",
            "kikuchi",
            "takagi",
            "takeda",
            "tanishima",
        };

        public static bool SetShuffleRegisters(string name)
        {
            return ShuffleRegisters.Add(name);
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "ハロー " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}