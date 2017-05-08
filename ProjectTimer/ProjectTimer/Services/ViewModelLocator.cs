using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using ProjectTimer.ViewModels;

namespace ProjectTimer.Services

{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<TimerViewModel>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public TimerViewModel Timer
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TimerViewModel>();
            }
        }
    }
}
