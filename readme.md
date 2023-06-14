# TodoApp REST API

This is a basic Todo app REST API built with ASP.NET Core Web API, Microsoft Entity Framework, Microsoft Logging, Swagger, and Microsoft.EntityFramework.InMemory. The purpose of this project is to provide a simple example of building a RESTful API using C# and the .NET framework.</br>

I had a few interactions with github copilot, so it took me about 30mins to get the basics of c# + .NET and coding the api.

## Prerequisites

- .NET Core SDK [Installation Guide](https://dotnet.microsoft.com/download)
- An Integrated Development Environment (IDE) like Visual Studio or Visual Studio Code

## Getting Started

1. Clone the repository:

```shell
    git clone https://github.com/LucasGabrielBecker/todoapp.csharp.git
```

2. Navigate to the project directory:

```shell
    cd todoapp.csharp
```

3. Build the project:

```shell
    dotnet build
```

4. Run the application:

```shell
    dotnet run
```

5. Open your web browser and go to http://localhost:5000/swagger/index.html to access the Swagger UI documentation. </br></br>

## Functionality

The TodoApp REST API provides the following endpoints:

```code
    - GET /api/todo: Get a list of all todos.
    - GET /api/todo/{id}: Get a specific todo by its ID.
    - POST /api/todo: Create a new todo.
    - PUT /api/todo/{id}: Update an existing todo.
    - DELETE /api/todo/{id}: Delete a todo.
```

## Libraries Used

```code
    - ASP.NET Core Web API
    - Microsoft Entity Framework
    - Microsoft Logging
    - Swagger
    - Microsoft.EntityFramework.InMemory
```

## Learning Resources

If you are new to C# and the .NET framework **just like i am**, here are some resources to help you get started:

[.NET Documentation](https://docs.microsoft.com/dotnet/)</br>
[C# Documentation](https://docs.microsoft.com/dotnet/csharp/)</br>
[ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core/)</br>
[Entity Framework Core Documentation](https://docs.microsoft.com/ef/core/)</br>
[Swagger Documentation](https://swagger.io/docs/)</br></br></br>

## Contributing

Contributions to this project are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.</br>

## License

This project is licensed under the [MIT License](https://chat.openai.com/LICENSE).
