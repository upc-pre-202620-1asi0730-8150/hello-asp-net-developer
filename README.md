# hello-asp-net-developer

## Summary

An ASP.NET Core REST API application to illustrate Object-Oriented Programming, Domain-Driven Design, and the use of Minimal APIs.

## Features

The API supports GET and POST requests for greeting metrics and personalized developer greetings.

- **GET /api/v1/greetings**: Retrieve the total count of greetings made to any developer.
- **POST /api/v1/greetings**: Create a personalized greeting with a JSON request body containing `firstName` and `lastName`.

## User Stories
The user stories for this project can be found in the [docs/user-stories.md](docs/user-stories.md) document.

## Class Diagram
The class diagram for this project can be found in the [docs/class-diagram.puml](docs/class-diagram.puml) document.

## Prerequisites

- .NET 10 SDK
- Swashbuckle.AspNetCore (for API documentation)

## Getting Started

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd hello-asp-net-developer

2. Restore dependencies:
   ```bash
    dotnet restore
    ```
3. Run the application:

   ```bash
   dotnet run
   ```
