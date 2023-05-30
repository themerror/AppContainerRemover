# AppContainerReovver

This application can remove an AppContainer.

You may use EnableLoopback to list ACs.

## What may happen if I removed an AppContainer

* If you remove an AC which is created by you for test purpose, nothing unexpected may happen.
* If you remove an AC which is used by an UWP app, the app will crash and then create a new AC again.
* If you remove an AC which is used by an packaged Win32 app, everything seems to run normally. If you want the container back again, just repair the app in Settings app or Powershell.