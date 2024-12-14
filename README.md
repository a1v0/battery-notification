# battery-notification

C# command-line application to create toast messages on Windows when the battery charge reaches a certain level.

My current goal is to send a notification when the battery is nearly fully charged, so that the battery doesn't overcharge (conventional wisdom seems to dictate that keeping a laptop plugged in is bad).

## Projects

To minimise RAM use, I have created two projects: one to check the battery status and a second to create the toast messages.

The latter is invoked only when necessary. (Exactly how this will happen is currently unclear. To avoid hard-coding the path to the EXE of the second project, I might invoke it from an event.)

## How to run

My current plan is to call the command every two-or-three minutes on a scheduled handled by Windows, though it might in future be run as a service.

### From published `exe`

I don't know how well this works in WSL, because my machine doesn't have the storage space to contain .NET 8 in Windows _and_ WSL. I had a problem, though, that, whenever publishing from WSL in .NET 6, a console window would always briefly pop up every time you run the file. This felt too janky.

My solution was to publish the app from Windows. Clone the repository into Windows and publish there.

N.B.: I have hard-coded the publish directory in the `.csproj` file, using a Windows-style file path.

### From the CLI

Currently, there is just have one argument you can pass: `full-battery`. If the battery is at or above a certain value (for argument's sake 98%), an alert will be triggered.
