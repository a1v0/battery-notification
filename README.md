# battery-notification

C# command-line application for Windows to send battery notifications.

My current goal is to send a notification when the battery is nearly fully charged, so that the battery doesn't overcharge (conventional wisdom seems to dictate that keeping a laptop plugged in is bad).

## How to run

My current plan is to call the command every two-or-three minutes on a scheduled handled by Windows, though it might in future be run as a service.

### From published `exe`

I don't know how well this works in WSL, because my machine doesn't have the storage space to contain .NET 8 in Windows _and_ WSL. I had a problem, though, that, whenever publishing from WSL in .NET 6, a console window would always briefly pop up every time you run the file. This felt too janky.

My solution was to publish the app from Windows.

N.B.: I have hard-coded the publish directory in the `.csproj` file, using a Windows-style file path.

### From the CLI

Currently, there is just have one argument you can pass: `full-battery`. If the battery is at or above a certain value (for argument's sake 98%), an alert will be triggered.
