# Blazor-Server-Side-Chat-Application
This repository is about the core concept of a simple chat application based on .Net Blazor Server-Side and SignalR. We made an effort to implement a simple chat application and the following system like any other social networking system. based on the user that you have followed, you can make a chat with your friends through the SignalR library. In this repository we concentrate on core aspects of the idea and of course that we can reform it. for instance, we can add any kind of design pattern and functions and classes to it. 

# What is SignalR:
SignalR is a library that allows server code to send asynchronous notifications to client-side web applications. The library includes server-side and client-side JavaScript components. 
SignalR has different features to allow you to create a connection between client and server like UserClaims or ConnectionId. In this example, we are trying to use ConnectionId to make a chat application. Moreover, with this approach, we can implement the online or offline status of users easily.


# About the project
In this project, we have used several technologies and libraries and each one is responsible for a component. To authenticate all users, we have used asp.net Identity and to create a chat connection between two users who are following together, we have used the SignalR library. In addition, we have used the Entity framework core to implement the communication with the SQL server.

# Libtraries and Packages : 
<code>Install-Package Microsoft.EntityFrameworkCore -Version 7.0.0-preview.2.22153.1</code>
