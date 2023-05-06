using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Dynamic;
using System.IO;
using azar1.Models;


namespace azar1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<azar> koss = new List<azar>();
            string mainconn = ConfigurationManager.ConnectionStrings["Koneksi"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string query = "select * from pd_grup";

            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                azar kos = new azar();
                kos.grp_ID = (int)dr["grp_ID"];
                kos.grp_name = dr["grp_name"].ToString();
                kos.Requestor = dr["Requestor"].ToString();
                kos.To_ = dr["To_"].ToString();
                kos.Job_description = dr["Job_description"].ToString();
                kos.picture = dr["picture"].ToString();
                
               
                koss.Add(kos);
            }
            return View(koss);
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