
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectTimer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimerPage : ContentPage
    {
        public TimerPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Timer;
        }
    }
}
