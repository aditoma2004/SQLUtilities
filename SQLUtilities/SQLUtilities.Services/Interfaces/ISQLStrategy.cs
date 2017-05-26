using System;

namespace SQLUtilities.Services
{
    public interface ISqlStrategy
    {
        void GenerateScripts(string tableName, string columnName, DateTime startDate, DateTime endDate);
    }
}
