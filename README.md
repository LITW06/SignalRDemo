# SignalRDemo

To get started with SignalR, create a class in the root of the application that inherits from Hub. Here's a sample:

https://github.com/LITW06/SignalRDemo/blob/master/SignalRDemo/ChatHub.cs

You'll then need to make sure to add the two following lines in the `Startup.cs` class:

https://github.com/LITW06/SignalRDemo/blob/master/SignalRDemo/Startup.cs#L26

https://github.com/LITW06/SignalRDemo/blob/master/SignalRDemo/Startup.cs#L42-L45 (on this line you don't have to use `/chathub`, you can use any URL you want)

Finally, on the page(s) that you'll want to use signalR, you'll need to add a reference to the signalR JavaScript:

https://github.com/LITW06/SignalRDemo/blob/master/SignalRDemo/Views/Home/Index.cshtml#L17

Good luck!
