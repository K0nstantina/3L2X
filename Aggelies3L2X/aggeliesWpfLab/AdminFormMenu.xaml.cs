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

namespace aggeliesWpfLab
{
    /// <summary>
    /// Interaction logic for AdminFormMenu.xaml
    /// </summary>
    public partial class AdminFormMenu : UserControl
    {
        public AdminFormMenu()
        {
            InitializeComponent();
        }
        public Button GetHomeB
        {
            get
            {
                return this.HomeB;
            }
        }
        public Button GetAdsB
        {
            get
            {
                return this.AdsB;
            }
        }
        public Button GetUsersB
        {
            get
            {
                return this.UsersB;
            }
        }
        public Button GetCategoriesB
        {
            get
            {
                return this.CategoriesB;
            }
        }
        public Button GetSettingsB
        {
            get
            {
                return this.SettingsB;
            }
        }
        public Button GetAnalyticsB
        {
            get
            {
                return this.AnalyticsB;
            }
        }
        public Button GetProfileB
        {
            get
            {
                return this.ProfileB;
            }
        }
    }
}
