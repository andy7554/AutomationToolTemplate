using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
namespace AutomationTool.SubForm
{
    /// <summary>
    /// CreateTestWindow.xaml 的互動邏輯
    /// </summary>
    public partial class CreateTestWindow : MetroWindow
    {
        DataTable dataTable = new System.Data.DataTable();

        public CreateTestWindow()
        {
            InitializeComponent();

            dataTable.Columns.Add("Checked", typeof(bool));
            dataTable.Columns.Add("TestName", typeof(string));
           

            DataRow row = dataTable.NewRow();
            row["Checked"] = true;
            row["TestName"] = "Speedometer V1";
            dataTable.Rows.Add(row);
            DataRow row2 = dataTable.NewRow();
            row2["Checked"] = true;
            row2["TestName"] = "Speedometer V2";
            dataTable.Rows.Add(row2);
            DataRow row3 = dataTable.NewRow();

            row3["Checked"] = true;
            row3["TestName"] = "Octane";
            dataTable.Rows.Add(row3);
            DataRow row4 = dataTable.NewRow();

            row4["Checked"] = true;
            row4["TestName"] = "Kraken 1.1";
            dataTable.Rows.Add(row4);
            DataRow row5 = dataTable.NewRow();

            row5["Checked"] = true;
            row5["TestName"] = "Webxprt 2015";
            dataTable.Rows.Add(row5);
            DataRow row6 = dataTable.NewRow();

            row6["Checked"] = true;
            row6["TestName"] = "PassMark";
            dataTable.Rows.Add(row6);
            DataRow row7 = dataTable.NewRow();

            row7["Checked"] = true;
            row7["TestName"] = "WebGL";
            dataTable.Rows.Add(row7);


            DataGridTestItem.ItemsSource = dataTable.DefaultView;


        }
    }
}
