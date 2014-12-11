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
        public MapControl()
        {
            InitializeComponent();
           
            Map.MouseLeftButtonUp += new MouseButtonEventHandler(mapClick);  
            
        }

        public void addPins(List<Article> myarticle)
        {
            InitializeComponent();
            Pushpin mypin;
            this.Map.Children.Clear();
            for (int i = 0; i < myarticle.Count; i++)
            {
                mypin = new Pushpin();
                //mypin.MouseUp += new MouseButtonEventHandler(mapClick);
                mypin.Location = new Location(myarticle[i].latitude, myarticle[i].longitude);
                mypin.Content = myarticle[i].Link;
                mypin.MouseLeftButtonUp += new MouseButtonEventHandler(mypin_MouseLeftButtonUp);
                mypin.ToolTip = myarticle[i].Title + "\n" + myarticle[i].Description;
                this.Map.Children.Add(mypin);
            }
            
        }

        void mypin_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
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
                    return;
                }
            }
            
        }
        
        
    }
}
