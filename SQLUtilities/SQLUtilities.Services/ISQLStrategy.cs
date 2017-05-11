using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLUtilities.Services
{
    public interface ISqlStrategy
    {
        void GenerateScripts(string tableName, string columnName, DateTime startDate, DateTime endDate);
    }
}
