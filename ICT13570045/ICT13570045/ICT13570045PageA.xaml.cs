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
	public partial class ICT13570045PageA : ContentPage
	{
		public ICT13570045PageA ()
		{
			InitializeComponent ();
            okButton.Clicked += OkButton_Clicked;
		}

        void OkButton_Clicked(object sender, EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }
    }
}