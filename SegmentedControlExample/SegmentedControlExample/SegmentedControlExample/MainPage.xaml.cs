using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SegmentedControlExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Segmented Control";
            BackgroundColor = Color.Green;
        }
        public void Handle_ValueChanged(object o, EventArgs e)
        {
            segmentedContent.Children.Clear();

            switch (SegControl.SelectedSegment)
            {
                case 0:
                    segmentedContent.Children.Add(new Label() { Text = "Aylık Maliyetiniz : 5000 ₺" });
                    break;
                case 1:
                    segmentedContent.Children.Add(new Label() { Text = "Yıllık Maliyetiniz : 60000 ₺" });
                    break;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SegControl.SetTintColor(Color.White);

            SegControl.SelectTab(0);
        }
    }
}
