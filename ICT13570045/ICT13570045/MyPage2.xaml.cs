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
	public partial class MyPage2 : ContentPage
	{
		public MyPage2 ()
		{
			InitializeComponent ();
            nextButton.Clicked += NextButton_Clicked;
            backButton.Clicked += BackButton_Clicked;
            
		}

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage1());
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}