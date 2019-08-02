using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasic.BusinessLayer;
using MVCBasic.Model;
using MVCBasic.WebApp.Models;

namespace MVCBasic.WebApp.Controllers
{
    public class CalculationController : Controller
    {
        // GET: Calculation
        public ActionResult Index(CalculationViewModel vm)
        {
            return View(vm);
        }

        public ActionResult Calculate(CalculationViewModel vm)
        {
            // 入力チェック
            if (vm.LeftNum == string.Empty || vm.RightNum == string.Empty)
            {
                return View();
            }

            // ViewModel -> Model
            var calculator = new Calculator();
            calculator.LeftNum = int.Parse(vm.LeftNum);
            calculator.RightNum = int.Parse(vm.RightNum);
            calculator.Operator = vm.SelectedOperator;

            // 計算
            var service = new CalculationService();
            var calculatedValue = service.calculate(calculator);

            // Model -> ViewModel
            var resultVM = new CalculationResultViewModel();
            resultVM.CalculatedValue = calculatedValue.ToString();

            return View("Result", resultVM);
        }
    }
}