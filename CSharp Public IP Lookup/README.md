# Public IP Lookup – C# Console App

This is a small C# console project I put together to learn more about networking in .NET.  
The app fetches your **public IP address** using the free API [`https://api.ipify.org`](https://api.ipify.org) and prints it out in the console.  

It’s a simple example, but it helped me understand how HTTP requests, JSON parsing, and asynchronous programming (`async`/`await`) work in practice.

---

## Features

- Makes an HTTP GET request to a public API
- Retrieves and displays your public IP in JSON format
- Handles errors (like no internet connection) without crashing
- Demonstrates async programming in C#

---

## Prerequisites

To run this project you’ll need:
- [.NET 6 or later SDK](https://dotnet.microsoft.com/download)
- A code editor (Visual Studio or VS Code both work fine)

---

## Project Structure

The project is kept very simple:
- **Program.cs** → main entry point with the async HTTP request
- No extra libraries or frameworks, just built‑in .NET classes
- Console output shows either your IP or an error message

---

## Notes

I built this mainly as a learning exercise, so it’s not meant to be fancy.  
If you’re new to C# and want to see how to make a quick API call, this is a good starting point. Feel free to clone it and experiment with different APIs.