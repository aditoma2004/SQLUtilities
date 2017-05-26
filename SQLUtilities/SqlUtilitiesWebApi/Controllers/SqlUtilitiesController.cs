using SQLUtilities.Services;
using SQLUtilities.Services.Interfaces;
using SqlUtilitiesWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SqlUtilitiesWebApi.Controllers
{
    public class SqlUtilitiesController : Controller
    {
        #region Private Fields

        private readonly IUkBankHolidayService bankHolidayService;

        #endregion

        #region Constructor
       
        public SqlUtilitiesController() : this(new UkBankHolidayService())
        {

        }       

        // Injectable constructor
        public SqlUtilitiesController(IUkBankHolidayService bankHolidayService)
        {
            this.bankHolidayService = bankHolidayService;           
        }

        #endregion

        #region Public Actons

        public ActionResult Index()
        {
            var model = new SqlUtilitiesModel
            {
                BankHolidayList = bankHolidayService.GetBankHolidays()
            };

            return View(model);
        }

        #endregion
    }
}
