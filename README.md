# battery-notification

A C# command-line application to create toast messages on Windows when the battery charge reaches a certain level.

My current goal is to send a notification when the battery is nearly fully charged, so that the battery doesn't overcharge (conventional wisdom seems to dictate that keeping a laptop plugged in is bad).

Runs on: Windows (10 and beyond), using .NET 8.0.

## Projects

To minimise RAM use, I have created two projects: one to check the battery status and a second to create the toast messages. The latter is invoked only when necessary.

(Due to JIT, splitting this project into two EXEs might be overkill. It adds a layer of brittleness, too, which I don't like.)

## How to run

The Windows Task Scheduler invokes this application every few minutes while the machine is connected to the power supply.

### From published `exe`

I don't know how well this works in WSL, because my machine doesn't have the storage space to contain .NET 8 in Windows _and_ WSL. I had a problem, though, that, whenever publishing from WSL in .NET 6, a console window would always briefly pop up every time you run the file. This felt too janky.

My solution was to publish the app from Windows. Clone the repository into Windows and publish there.

N.B.: I have hard-coded the publish directory in the `.csproj` files, using a Windows-style file path.

Both projects must live in the same published directory, and the toast icon files must also reside there.

### From the CLI

Currently, there is just have one argument you can pass to the `BatteryNotification` project: `full-battery`. If the battery is at or above a certain value (for argument's sake 98%), an alert will be triggered.

However, using `dotnet run` won't work very well, because `BatteryNotification` invokes an EXE file of the `ToastUtility`.

This is an inconvenience that I don't know how to fix, unless I do a major refactor and invoke `ToastUtility` directly through code, not by opening an EXE.
