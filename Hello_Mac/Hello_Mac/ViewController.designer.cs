// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Hello_Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ClickedLabel { get; set; }

		[Action ("Click:")]
		partial void Click (Foundation.NSObject sender);

		[Action ("Clicked:")]
		partial void Clicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickedLabel != null) {
				ClickedLabel.Dispose ();
				ClickedLabel = null;
			}
		}
	}
}
