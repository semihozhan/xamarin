using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class test : ContentPage
	{
		public test ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Masters());
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Tabbet());
        }
        private void Button_Clicked3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Carousel());
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            
            Ent.Text = "Auto Filled";
            Sld.Value = 0.5;
            Dt.Date = new DateTime(2017,02,12);
            Tm.Time = new TimeSpan(10,10,10);
            swtt.IsToggled = true;
            Btn.Text = "Btn Status was Clicked";

            var myList = new List<String>();
            myList.Add("First");
            myList.Add("Second");
            myList.Add("Thirtd");

            Pk.ItemsSource = myList;
        }

        private void Pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = Pk.SelectedItem.ToString();
        }
    }
}