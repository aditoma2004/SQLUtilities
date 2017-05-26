using SQLUtilities.Services.Models;
using System.Collections.Generic;


namespace SQLUtilities.Services.Interfaces
{
   public interface IUkBankHolidayService
    {
       IList<UkBankHolidayServiceModel> GetBankHolidays();
    }
}
