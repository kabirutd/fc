﻿using Microsoft.AspNetCore.Mvc;

namespace fc.Controllers
{
    public class RMAController : Controller
    {
        public IActionResult Index(string? custnum)
        {
            string? cust_num = custnum;

            ViewData["cust_num"] = cust_num;
            return View();
        }

        public IActionResult RMA(string? custnum)
        {
            string? cust_num = custnum;

            ViewData["cust_num"] = cust_num;
            return View();
        }

        public IActionResult RMAV2(string? custnum)
        {
            //get cust_num from
            string? cust_num = custnum;
           
            ViewData["cust_num"] = cust_num;
            return View();
        }
    }
}
