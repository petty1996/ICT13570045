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
	public partial class NavePage2 : ContentPage
	{
		public NavePage2 ()
		{
			InitializeComponent ();
            nextButton.Clicked += NextButton_Clicked;
            backButton.Clicked += BackButton_Clicked;
		}

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage3());
        }
         void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}