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

namespace trackingSimulator001
{
    public partial class Form1 : Form
    {
        double zoom_value = 15;
        public Form1()
        {
            InitializeComponent();

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(37.495, 127.025);
            gMapControl1.Zoom = zoom_value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(zoom_value > 30)
            {
                zoom_value = 0;
            }
            else
            {
                zoom_value++;
            }
            gMapControl1.Zoom = zoom_value;
        }
    }
}
