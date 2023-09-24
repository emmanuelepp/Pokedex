# Pokedex Project

This project is a web application that consumes a Pokémon API to provide information about different Pokémon. It uses an architecture based on Domain-Driven Design (DDD) and has been implemented with good development practices, including unit testing.

## Features

- Query Pokémon information by name.
- Paginated Pokémon list.
- Well-organized DDD-based architecture.
- Unit tests for controller logic.

## Technologies Used

- **ASP.NET Core**: The backend of the application is built on ASP.NET Core, which is an open-source web development framework.
- **Blazor WebAssembly**: The frontend of the application is constructed with Blazor WebAssembly, allowing interactive web applications to be built in C#.
- **xUnit**: A unit testing framework used to test the controller logic.

## Architecture

The architecture of this project follows a DDD-based approach. This means it's divided into layers of domain, application, and presentation. Here's a brief description of each:

- **Domain**: Contains entities, aggregates, repositories, and services representing the business logic of the application. It also includes Data Transfer Objects (DTOs) used for data exchange between layers.

- **Application**: This is where the application logic resides. Application services interact with the domain and provide an interface for the presentation layers.

- **Presentation**: This layer contains the user interface and is built with Blazor WebAssembly. Pages, components, and presentation services are managed here.

## Local Execution

To run the project locally, follow these steps:

1. Clone this repository to your local machine.

2. Open the solution in your favorite IDE (e.g., Visual Studio).

3. Ensure you have .NET Core SDK installed on your machine.

4. Open a terminal and navigate to the API project directory (e.g., `Pokedex.Api`).

5. Run the `dotnet run` command to start the API.

6. Open another terminal and navigate to the Blazor client project directory (e.g., `Pokedex.Client`).

7. Run the `dotnet run` command to start the Blazor client.

8. Keep both the API and client running simultaneously.

9. Open your browser and visit `https://localhost:5001` to access the application.

## Unit Testing

Unit tests have been included for the controller logic. To run the tests, use the following command in the respective directory:

