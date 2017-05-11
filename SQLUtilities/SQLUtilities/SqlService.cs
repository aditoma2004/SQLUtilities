using System;
using System.IO;

namespace SQLUtilities
{
    public class SqlService
    {    
        public void GenerateScripts(string tableName, string columnName, DateTime startDate, DateTime endDate)
        {
            string insertScript = "INSERT INTO " + tableName + "(" + columnName + ", OrderCounter, MaxOrderLimitPerDay) VALUES ";

            string finalScript = String.Empty;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                finalScript += insertScript + "('" + date.Date.ToString("yyyy-MM-dd hh:mm:ss") + "', 0, 700)" + Environment.NewLine;
            }

            string fileName = "D:\\insert" + tableName + ".sql";
            using (StreamWriter file = new StreamWriter(fileName))
            {
                file.WriteLine(finalScript);
            }
        }
    }
}