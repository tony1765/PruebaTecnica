using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace PruebaTecnicaFrontEnd.Controllers
{
    public class AutosController : Controller
    {
        // GET: Autos
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult ObtenerAutos() {
          
            using (WSAutos.AutosClient Client = new WSAutos.AutosClient())
            {
                return Json(Client.ObtenerAutos());
            }
            
        }
    }
}