# battery-notification

C# command-line application for Windows to send battery notifications.

My current goal is to send a notification when the battery is nearly fully charged, so that the battery doesn't overcharge (conventional wisdom seems to dictate that keeping a laptop plugged in is bad).

## How to run

Currently, there is just have one argument you can pass: `full-battery`. If the battery is at or above a certain value (for argument's sake 98%), an alert will be triggered.

My current plan is to call the command every two-or-three minutes on a scheduled handled by Windows, though it might in future be run as a service.

## Publish directory

I have hard-coded the publish directory in the `.csproj` file.
