using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppNew
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        void OnValueChanged(object slider, ValueChangedEventArgs args)
        {
            if (slider == redSlider)
            {
                redLabel.Text = String.Format("Red = {0}", (int)args.NewValue);
            }
            else if (slider == greenSlider)
            {
                greenLabel.Text = String.Format("Green = {0}", (int)args.NewValue);
            }
            else if (slider == blueSlider)
            {
                blueLabel.Text = String.Format("Blue = {0}", (int)args.NewValue);
            }
            else if (slider == brightnessSlider)
            {
                brightnessLabel.Text = String.Format("Brightness = {0}", (int)args.NewValue);
            }

            boxView.Color = Color.FromRgba((int)redSlider.Value, (int)greenSlider.Value, 
                (int)blueSlider.Value, (int)brightnessSlider.Value);
        }
    }
}