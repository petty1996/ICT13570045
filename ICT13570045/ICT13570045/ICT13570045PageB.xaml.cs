using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13570045
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ICT13570045PageB : ContentPage
	{
		public ICT13570045PageB ()
		{
			InitializeComponent ();
            okButton.Clicked += OkButton_Clicked;
            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += Myslider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;
        }
        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }
        void Myslider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}