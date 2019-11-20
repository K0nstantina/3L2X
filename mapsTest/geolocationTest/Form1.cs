using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geolocationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            // This line DOESNT work. Comment and use next snippet.
            map.SetPositionByKeywords("Greece");

            /* Uncomment below and comment before to see the difference */
            //PointLatLng point;
            //if (cityTextBox.Text != string.Empty)
            //{
            //    map.GetPositionByKeywords(cityTextBox.Text, out point);
            //    map.Position = point;
            //}
            //else
            //{
            //    map.Position = new PointLatLng(40.634781, 22.943090);
            //}


            /* Uncomment below and comment before to see the difference */
            //map.MapProvider = BingMapProvider.Instance;
            //GMaps.Instance.Mode = AccessMode.ServerOnly;
            //map.SetPositionByKeywords("Paris, France");
            //map.ShowCenter = false;

            //GMapOverlay markers = new GMapOverlay("markers");
            //GMapMarker marker = new GMarkerGoogle(
            //    new PointLatLng(48.8617774, 2.349272),
            //    GMarkerGoogleType.blue_pushpin);
            //markers.Markers.Add(marker);
            //map.Overlays.Add(markers);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
