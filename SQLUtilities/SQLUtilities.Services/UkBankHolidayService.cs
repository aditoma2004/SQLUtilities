using SQLUtilities.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLUtilities.Services.Models;
using SqlUtilities.Entities;

namespace SQLUtilities.Services
{
    public class UkBankHolidayService : IUkBankHolidayService
    {
        public IList<UkBankHolidayServiceModel> GetBankHolidays()
        {
            var result = new List<UkBankHolidayServiceModel>();

            try
            {
                using (var db = new KeepupDbEntities())
                {
                    
                    foreach(var bankHoliday in db.BankHolidays)
                    {
                        result.Add(new UkBankHolidayServiceModel {
                            BankHolidayDate = bankHoliday.BankHolidayDate,
                            BankHolidayDescription = bankHoliday.BankHolidayDescription
                        });
                    }

                   
                    return result;
                }
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
