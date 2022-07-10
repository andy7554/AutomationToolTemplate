using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;

namespace AutomationTool
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        TabPage.UserControl1 uc1 = new TabPage.UserControl1();
        TabPage.UserControl2 uc2 = new TabPage.UserControl2();
        TabPage.UserControl3 uc3 = new TabPage.UserControl3();

        public MainWindow()
        {
            InitializeComponent();
            this.TabItem1.Content = uc1;
            this.TabItem2.Content = uc2;
            this.TabItem3.Content = uc3;
        }
    }
}
