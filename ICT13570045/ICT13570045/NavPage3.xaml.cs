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
	public partial class NavPage3 : ContentPage
	{
		public NavPage3 ()
		{
			InitializeComponent ();
            backButton.Clicked += BackButton_Clicked;
            backToRoot.Clicked += BackToRoot_Clicked;
		}

       void BackToRoot_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

         void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}