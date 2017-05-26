using SQLUtilities.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlUtilitiesWebApi.Models
{
    public class SqlUtilitiesModel
    {
        #region Properties
        public string SqlTableName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<DayOfWeek> ExcludedDays { get; set; }

        public IList<UkBankHolidayServiceModel> BankHolidayList { get; set; }

        #endregion

        #region Constructor

        public SqlUtilitiesModel()
        {
            ExcludedDays = new List<DayOfWeek>();
            BankHolidayList = new List<UkBankHolidayServiceModel>();
        }

        #endregion
    }
}