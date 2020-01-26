using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        DateTime dt;

        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        bool OnTimerTick()
        {

            if (_swtch.IsToggled && DateTime.Now > dt)
            {
                _swtch.IsToggled = false;
                CrossLocalNotifications.Current.Show(_entry.Text, _editor.Text/*, 101, DateTime.Now.AddSeconds(5)*/);
            }
            return true;

        }


        void TimePickerPropertyChanged(Object o,PropertyChangedEventArgs e)
        {

            if (e.PropertyName=="Time")
            {
                setTriggerTime();
            }
        }


        void OnSwitchToggled(Object o, EventArgs e)
        {
            setTriggerTime();
        }


        void setTriggerTime()
        {
            dt = DateTime.Today + _TimeP.Time;
            if (dt < DateTime.Now)
            {
                dt += TimeSpan.FromDays(1);
            }
        }



    }
}
