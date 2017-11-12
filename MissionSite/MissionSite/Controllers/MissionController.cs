using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MissionSite.Models;

namespace MissionSite.Controllers
{
    public class MissionController : Controller
    {
        List<Mission> model = new List<Mission>
        {
            new Mission("Mexico Reynosa", "Jorge Alejandro Regalado Campos", "Mexico Reynosa Mission <br />Av. Fundadores #100 Esq. con Entresuelo <br />Col. Ribereña <br />Reynosa, Tamaulipas <br />Mexico C.P. 88620", "Spanish", "Reynosa has a semi-arid climate with short, mild winters and hot summers", "Catholicism", "~/Content/Images/mexicoFlag.png"),
            new Mission("Nevada Las Vegas", "President D. Jack Snow", "9270 South Maryland Parkway <br />Las Vegas, NV 89123", "English", "Las Vegas has a subtropical hot desert climate, typical of the Mojave Desert in which it lies. This climate is typified by long, very hot summers; warm transitional seasons; and short, mild to chilly winters.", "Atheism", "~/Content/Images/nevadaFlag.png"),
            new Mission("Oklahoma Oklahoma City", "Darren J. Mansell", "416 SW 79th St Ste 210 <br />Oklahoma City, OK 73139", "English", "Oklahoma City has a temperate humid subtropical climate, with frequent variations in weather daily and seasonally, except during the consistently hot and humid summer months.", "Baptist", "~/Content/Images/oklahomaFlag.png")
        };

        // GET: Mission
        public ActionResult Index()
        {
            return View(model);
        }

        public ActionResult MissionPage(string MisName)
        {
            ViewBag.MisName = MisName;
            ViewBag.Message = "hello";
            return View(model);
        }
    }
}