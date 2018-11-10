using CustomerManager.Core;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;

namespace CustomersManager.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }
    }
}