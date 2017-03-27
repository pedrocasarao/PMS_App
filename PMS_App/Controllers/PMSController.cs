using PMS_App.ET;
using PMS_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS_App.Controllers
{
    public class PMSController : Controller
    {
        // GET: PMS
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetProjeto()
        {

            PMSDataAccess data = new PMSDataAccess();
            List<Projeto> listProjeto = data.PMSlistProjeto.ToList();
            return Json(listProjeto, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetUsuario()
        {

            PMSDataAccess data = new PMSDataAccess();
            List<Usuario> listUsuario = data.PMSlistUsuario.ToList();
            return Json(listUsuario, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOcorrencia()
        {

            PMSDataAccess data = new PMSDataAccess();
            List<Ocorrencia> listOcorrencia = data.PMSlistOcorrencia.ToList();
            return Json(listOcorrencia, JsonRequestBehavior.AllowGet);
        }
    }
}