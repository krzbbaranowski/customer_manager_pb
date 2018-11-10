// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CustomersManager.iOS.Views.Customers
{
	[Register ("CustomersListView")]
	partial class CustomersListView
	{
		[Outlet]
		UIKit.UIButton AddButton { get; set; }

		[Outlet]
		UIKit.UITableView Customers { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Customers != null) {
				Customers.Dispose ();
				Customers = null;
			}

			if (AddButton != null) {
				AddButton.Dispose ();
				AddButton = null;
			}
		}
	}
}
