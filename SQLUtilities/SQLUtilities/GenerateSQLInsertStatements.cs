using SQLUtilities.Services;
using System;
using System.Windows.Forms;

namespace SQLUtilities
{
    public partial class GenerateSQLInsertStatements : Form
    {
        public GenerateSQLInsertStatements()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ISqlStrategy sqlService = new SqlInsertStrategy();
            sqlService.GenerateScripts(txtTableName.Text, txtFirstColumn.Text, dtStartDate.Value, dtEndDate.Value);
        }
    }
}