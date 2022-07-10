using AutomationTool.SubForm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace AutomationTool.TabPage
{
    /// <summary>
    /// UserControl1.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public ObservableCollection<ListViewBinding> _DataList = new ObservableCollection<ListViewBinding>();

        public UserControl1()
        {
            InitializeComponent();
            ListViewBinding _data = new ListViewBinding();
            _data.Checked = true;
            _data.Device = "Device1";
            _data.IPAddress = "192.168.0.101"; 
            _data.Status = "Online";
            _DataList.Add(_data);

            _data.Checked = true;
            _data.Device = "Device2";
            _data.IPAddress = "192.168.0.102";
            _data.Status = "Online";
            _DataList.Add(_data);

            DataGridDeviceList.ItemsSource = _DataList;

        }

        public class ListViewBinding : INotifyPropertyChanged
        {
            private bool _IsEnable = true;
            private bool _Checked = false;
            private string _Device = "";
            private string _IPAddress = "";
            private string _Status = "";

            public bool IsEnable
            {
                get { return _IsEnable; }
                set
                {
                    _IsEnable = value;
                    NotifyPropertyChanged("IsEnable");
                }
            }

            public bool Checked
            {
                get { return _Checked; }
                set
                {
                    _Checked = value;
                    NotifyPropertyChanged("Checked");
                }
            }
            public string Device
            {
                get { return _Device; }
                set
                {
                    _Device = value;
                    NotifyPropertyChanged("Device");
                }
            }
            public string IPAddress
            {
                get { return _IPAddress; }
                set
                {
                    _IPAddress = value;
                    NotifyPropertyChanged("IPAddress");
                }
            }
            public string Status
            {
                get { return _Status; }
                set
                {
                    _Status = value;
                    NotifyPropertyChanged("Status");
                }
            }

           
            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }


        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            CreateTestWindow testWindow = new CreateTestWindow();
            testWindow.ShowDialog();


        }
    }
}
