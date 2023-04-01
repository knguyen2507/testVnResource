using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestVnResource.Models;
using static TestVnResource.Models.VNR_InternShipEntities;

namespace TestVnResource.Controllers
{
    public class IndexController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            VNR_InternShipEntities db = new VNR_InternShipEntities();
			// Lay ds cac Khoa Hoc
			List<KhoaHoc> khoahocs = db.KhoaHocs.ToList();
			// Lay ds cac Mon Hoc
			List<MonHoc> monhocs = db.MonHocs.ToList();

			ViewBag.paramMonHoc = monhocs;
			ViewBag.paramKhoaHoc = khoahocs;

			return View();
        }
	}
}