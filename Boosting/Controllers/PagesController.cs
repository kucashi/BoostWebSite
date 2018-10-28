using Boosting.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Boosting.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Diablo3()
        {
            return View();
        }

        public ActionResult Destiny2()
        {
            return View();
        }

        public ActionResult HelpCenter()
        {
            return View();
        }
        
        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Test()
        {
            List<OrdersModel> customers = new List<OrdersModel>();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                string query = "SELECT BattleNetUser, BattleNetPass FROM orders";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            customers.Add(new OrdersModel
                            {
                                battleNetUser = sdr["BattleNetUser"].ToString(),
                                battleNetPassword = sdr["BattleNetPass"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }

            return View(customers);
        }
    }
}