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
using System.Collections;
using Newtonsoft.Json;

namespace TestVnResource.Controllers
{
    public class IndexController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            VNR_InternShipEntities db = new VNR_InternShipEntities();
			dynamic op = new ExpandoObject();
			// Lay ds cac Khoa Hoc
			List<KhoaHoc> khoahocs = db.KhoaHocs.ToList();
			// Lay ds cac Mon Hoc
			List<MonHoc> monhocs = db.MonHocs.ToList();

			List<object> results = new List<object>();


			op.MonHoc = monhocs;
			op.KhoaHoc = khoahocs;

			return View(op);
        }

		[HttpPost]
		public ActionResult ShowData(string id)
		{
			int input = Int32.Parse(id);

			VNR_InternShipEntities db = new VNR_InternShipEntities();
			List<MonHoc> monhocs = db.MonHocs.ToList();
			List<string> results = new List<string>();

			foreach (MonHoc monHoc in monhocs)
			{
				if (monHoc.KhoaHocID == input)
				{
					results.Add(monHoc.TenMonHoc);
				}
			}

			var output = JsonConvert.SerializeObject(results);
			return Json(output);
		}
	}
}