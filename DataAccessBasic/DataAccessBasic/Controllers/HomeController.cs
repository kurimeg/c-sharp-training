using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;

namespace DataAccessBasic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string sql =
                @"SELECT
                      RQST_TYP
	                    , RQST_NM
	                    , DSPLY_ORDR
	                    , CRT_USR_ID
	                    , CRT_TMSTMP
	                    , LST_UPDT_USR_ID
	                    , LST_UPDT_TMSTMP
	                    , DLT_FLG
                    FROM
                      M_RQST_TYP
                    WHERE
                      RQST_TYP = @RQST_TYP
                    ORDER BY
                      RQST_TYP";
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PSS;Integrated Security=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                int RQST_TYP = 1;
                string RQST_NM = "";
                var orderDetail = connection.Query(sql, new { RQST_TYP });
            }

            return View();
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