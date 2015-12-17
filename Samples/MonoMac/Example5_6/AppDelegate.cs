using System;
using System.Drawing;
using Foundation;
using AppKit;
using ObjCRuntime;

namespace Example5_6
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;
		
		public AppDelegate ()
		{
		}

		public override void FinishedLaunching (NSObject notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);
			//RectangleF bounds = mainWindowController.Window.ContentView.Bounds;
			//bounds.Inflate(-50,-50);
			mainWindowController.Window.ContentView.AddSubview(new ChartCanvas(mainWindowController.Window.ContentView.Bounds));
			//mainWindowController.Window.ContentView.AddSubview(new ChartCanvas(bounds));
		}
		
		public override bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
		{
			return true;
		}
	}
}

