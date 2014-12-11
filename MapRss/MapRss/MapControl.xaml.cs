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
using Microsoft.Maps;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Design;
using System.Windows.Controls.Primitives;
using System.Diagnostics;

namespace MapRss
{
    /// <summary>
    /// Interaction logic for MapControl.xaml
    /// </summary>
    public partial class MapControl : UserControl
    {

        public event MouseButtonEventHandler clicked;
        public double offset;
        public MapControl()
        {
            InitializeComponent();
            offset = 1;
            Map.MouseLeftButtonUp += new MouseButtonEventHandler(mapClick);
            Map.MouseLeftButtonUp += new MouseButtonEventHandler(doubleClick_offset);
        }

        public void addPins(List<Article> myarticle)
        {
            InitializeComponent();
            //Pushpin mypin;
            this.Map.Children.Clear();
            for (int i = 0; i < myarticle.Count; i++)
            {
                Pushpin mypin = new Pushpin();
                mypin.Location = new Location(myarticle[i].latitude, myarticle[i].longitude);
                mypin.Content = myarticle[i].Link;
                mypin.ToolTip = myarticle[i].Title + "\n" + myarticle[i].Description;
                this.Map.Children.Add(mypin);
            }
            
        }

        
       
        private void mapClick(object sender, MouseButtonEventArgs e)
        {
            Popup display = new Popup();
            LocationConverter locationConverter = new LocationConverter();
            int count = this.Map.Children.Count;
            Point clickPoint = e.GetPosition(this);
            Location clickLocation = Map.ViewportPointToLocation(clickPoint);
            Pushpin testPin;
            for (int i = 0; i < count; i++)
            {
                //check for if a pin is hit by this mouse click
                testPin  = (Pushpin)Map.Children[i];
                double check_lat =  testPin.Location.Latitude - clickLocation.Latitude;
                double check_long = testPin.Location.Longitude  - (clickLocation.Longitude+40);
                if((0 < check_lat && check_lat < 4) && (-2 < check_long && check_long < 2))
                {
                    //Process.Start(testPin.Content.ToString());
                    if(null != clicked)
                    {
                        clicked(testPin.Content, null);
                    }
                    return;
                }
            }
            
        }
        private void doubleClick_offset(object sender, MouseButtonEventArgs e)
        {
           
            LocationConverter locationConverter = new LocationConverter();
            int count = this.Map.Children.Count;
            Point clickPoint = e.GetPosition(this);
            Location clickLocation = Map.ViewportPointToLocation(clickPoint);
            double check_lat = clickLocation.Latitude;
            double check_long = clickLocation.Longitude;
            return;
        }
        
        
    }
}
