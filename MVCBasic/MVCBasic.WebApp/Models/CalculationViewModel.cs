using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic.WebApp.Models
{
    public class CalculationViewModel
    {
        public CalculationViewModel()
        {
            Operators = new SelectListItem[]{
                new SelectListItem(){ Value ="＋", Text = "＋"},
                new SelectListItem(){ Value ="－", Text = "－"},
                new SelectListItem(){ Value ="×", Text = "×"},
                new SelectListItem(){ Value ="÷", Text = "÷"},
            };
        }

        public string LeftNum { get; set; }

        public string RightNum { get; set; }

        public SelectListItem[] Operators { get; set; }
        public string SelectedOperator { get; set; }
    }
}