using System;
using CoreGraphics;
using CustomerManager.Core.ViewModels;
using CustomersManager.iOS.Views.Customers.Cells;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace CustomersManager.iOS.Views.Customers
{
    [MvxRootPresentation()]
    public partial class CustomersListView : MvxViewController<CustomersListViewModel>
    {
        private MvxSimpleTableViewSource _source;

        public CustomersListView() : base("CustomersListView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Customers.RegisterNibForCellReuse(CustomersCellView.Nib, CustomersCellView.Key);
            Customers.RowHeight = 100;

            _source = new MvxSimpleTableViewSource(Customers, CustomersCellView.Key);
            Customers.Source = _source;

            var set = this.CreateBindingSet<CustomersListView, CustomersListViewModel>();
            set.Bind(_source).To(vm => vm.Customers);
            set.Bind(_source).For(v => v.SelectionChangedCommand).To(vm => vm.CustomerItemClickCommand);
            set.Apply();

            SetupFabButton();
        }

        private void SetupFabButton()
        {
            AddButton.Layer.ShadowColor = UIColor.Black.CGColor;
            AddButton.Layer.ShadowOffset = new CGSize(width: 0.0, height: 2.0);
            AddButton.Layer.MasksToBounds = false;
            AddButton.Layer.ShadowRadius = 1.0f;
            AddButton.Layer.ShadowOpacity = 0.5f;
            AddButton.Layer.CornerRadius = AddButton.Frame.Width / 2;
        }
    }
}