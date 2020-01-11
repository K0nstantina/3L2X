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
    /// Interaction logic for DisplayAd.xaml
    /// </summary>
    public partial class DisplayAd : UserControl
    {
        public DisplayAd()
        {
            InitializeComponent();
        }

        public Image GetadImage
        {
            get
            {
               return this.adImage;
            }
        }

        public TextBlock GetadTitle
        {
            get
            {
                return this.adTitle;
            }
        }

        public TextBox GetadDesc
        {
            get
            {
                return this.adDesc;
            }
        }
    }
}
