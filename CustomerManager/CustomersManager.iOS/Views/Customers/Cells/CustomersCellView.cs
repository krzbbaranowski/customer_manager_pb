using System;
using CustomerManager.Core.PO;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace CustomersManager.iOS.Views.Customers.Cells
{
    public partial class CustomersCellView : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("CustomersCellView");
        public static readonly UINib Nib;

        static CustomersCellView()
        {
            Nib = UINib.FromName("CustomersCellView", NSBundle.MainBundle);
        }

        protected CustomersCellView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            this.DelayBind(() =>
            {
                CustomerAvatar.LoadingPlaceholderImagePath = "res:user_placeholder.jpg";
                CustomerAvatar.ErrorPlaceholderImagePath = "res:user_placeholder.jpg";

                var set = this.CreateBindingSet<CustomersCellView, CustomerListItemPO>();

                set.Bind(CustomerName).For(v => v.Text).To(vm => vm.FullName);
                set.Bind(CustomerAvatar).For(v => v.ImagePath).To(vm => vm.AvatarUrl);
                set.Bind(CustomerTelephoneNumber).For(v => v.Text).To(vm => vm.Number);
                set.Apply();

            });
        }
    }
}