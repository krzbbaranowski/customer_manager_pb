// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CustomersManager.iOS.Views.Customers.Cells
{
	[Register ("CustomersCellView")]
	partial class CustomersCellView
	{
		[Outlet]
		FFImageLoading.Cross.MvxCachedImageView CustomerAvatar { get; set; }

		[Outlet]
		UIKit.UILabel CustomerName { get; set; }

		[Outlet]
		UIKit.UILabel CustomerTelephoneNumber { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CustomerAvatar != null) {
				CustomerAvatar.Dispose ();
				CustomerAvatar = null;
			}

			if (CustomerName != null) {
				CustomerName.Dispose ();
				CustomerName = null;
			}

			if (CustomerTelephoneNumber != null) {
				CustomerTelephoneNumber.Dispose ();
				CustomerTelephoneNumber = null;
			}
		}
	}
}
