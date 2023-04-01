using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestVnResource.Models;
using static TestVnResource.Models.VNR_InternShipEntities;

namespace TestVnResource.Controllers
{
    public class DefaultController : Controller
    {
		public List<MonHoc> GetData(int id)
		{
			VNR_InternShipEntities db = new VNR_InternShipEntities();
			List<MonHoc> results = db.MonHocs.ToList();
			return results;
		}
	}
}