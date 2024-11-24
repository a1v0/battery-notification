# battery-notification

C# command-line application for Windows to send battery notifications.

My current goal is to send a notification when the battery is nearly fully charged, so that the battery doesn't overcharge (conventional wisdom seems to dictate that keeping a laptop plugged in is bad).

## How to run

Currently, we just have one argument you can pass: `check-full`. If the battery is at or above a certain value (for argument's sake 98%), some sort of notification will be fired.

My current plan is to call the command every two-or-three minutes on a scheduled handled by Windows, though it might in future be run as a service.
