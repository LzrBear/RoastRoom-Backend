# RoastRoom-Backend

This is the backend for RoastRoom, built with ASP.NET Core Web API and Entity Framework Core.

## Getting Started

1. Navigate to `RoastRoom-Backend`
2. Restore dependencies:
   ```powershell
   dotnet restore
   ```
3. Update the database (if using migrations):
   ```powershell
   dotnet ef database update
   ```
4. Run the API:
   ```powershell
   dotnet run
   ```

## Features
- User authentication and registration (ASP.NET Identity)
- Create, view, comment, and rate posts
- RESTful API endpoints
- Entity Framework Core for data access

## Project Structure
- `Controllers/`: API controllers
- `Models/`: Data models
- `Data/`: Database context
- `appsettings.json`: Configuration

## Requirements
- .NET 6.0 or newer
- SQL Server (or update connection string for your DB)

## License
MIT
