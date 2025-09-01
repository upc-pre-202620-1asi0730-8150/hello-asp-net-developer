# hello-asp-net-developer

## Summary

An ASP.NET Core REST API application to illustrate the use of Minimal APIs.

## Features

The API supports both GET and POST requests to generate personalized greetings based on a developer's first and last
names.

- **GET /greetings**: Retrieve a greeting with optional `firstName` and `lastName` query parameters.
- **POST /greetings**: Create a greeting with a JSON request body containing `firstName` and `lastName`.

## User Stories
The user stories for this project can be found in the [docs/user-stories.md](docs/user-stories.md) document.

## Class Diagram
The class diagram for this project can be found in the [docs/class-diagram.md](docs/class-diagram.md) document.

The following diagram shows the class hierarchy for the application:
![class-diagram](https://plantuml.com/plantuml/proxy?src=)

## Prerequisites

- .NET 9 SDK
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
