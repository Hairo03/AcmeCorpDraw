# Acme Corporation Prize Draw

A Blazor Server web application for managing prize draw submissions with serial number validation.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server)
- Visual Studio 2026

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/Hairo03/AcmeCorpDraw.git
cd AcmeCorpDraw
```

### 2. Configure the Database Connection

Update the connection string in `AcmeCorpDraw.WebApp\appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=AcmeCorpDrawDb;Integrated Security=True;TrustServerCertificate=True"
  }
}
```

Adjust the `Server` value to match your SQL Server instance name if different.

### 3. Apply Database Migrations

Open the Package Manager Console, select the AcmeCorpDraw.WebApp as the as the default project and run:

```bash
update-database
```

This will create the database and seed 100 valid serial numbers in the format `ACME-XXXX-XXXX-XXXX`.

### 4. Run the Application

```bash
dotnet run
```

The application will start at `https://localhost:7XXX` (check console output for exact port).

Open your browser and navigate to the URL displayed in the console.

## Features

### Submission Form
- **Route**: `/` (Home page)
- Validates first name, last name, email, serial number, and date of birth
- Enforces 18+ age requirement with custom validation attribute
- Validates serial numbers against database
- Limits entries to 2 per serial number (global limit)
- Data normalization: emails stored in lowercase, serial numbers in uppercase
- Loading state prevents duplicate submissions

### All Submissions Report
- **Route**: `/all-submissions`
- Displays all submissions in a table sorted by submission date (newest first)
- Shows submission timestamp
- Uses API endpoint for data retrieval

### API Endpoints
- `GET /api/submissions` - Get all submissions
- `GET /api/submissions/page/{pageNumber}` - Get paginated submissions (10 per page)
- `GET /api/submissions/count` - Get total submission count
- `GET /api/submissions/{id}` - Get submission by ID
- `POST /api/submissions` - Create new submission
- `GET /api/submissions/count/{serialNumber}` - Get entry count for specific serial number

## Sample Serial Numbers

All valid serial numbers can be found in the serial-numbers.txt file.
Here are 10 examples from the 100 pre-seeded serial numbers you can use for testing:

1. `ACME-0JIE-XYX2-N0AT`
2. `ACME-0OIF-73CP-X5VS`
3. `ACME-0W6O-6ELF-XET8`
4. `ACME-21TB-AP2C-IJB2`
5. `ACME-3GPO-KOQL-YT6J`
6. `ACME-44YA-X9EL-ATXA`
7. `ACME-6GIQ-BUDW-I8FL`
8. `ACME-7JV9-ZD6H-9V9E`
9. `ACME-AM44-21NZ-7BAO`
10. `ACME-B0J4-DWMP-AL4O`

All 100 serial numbers are automatically seeded when you run the database migrations.

## Technologies Used

- **ASP.NET Core Blazor Server** (.NET 10, C# 14.0)
- **Entity Framework Core** with SQL Server
- **MSTest** with **Moq** for unit testing
- **Bootstrap 5** for UI styling

## Architecture Patterns

- **Repository Pattern**: Abstracts data access layer with interfaces in Domain project, implementations in WebApp
- **Service Layer**: Contains business logic, validation, and data normalization
- **DTO Pattern**: Separates data transfer objects (with validation) from domain models
- **Dependency Injection**: All services registered as Scoped in Program.cs
- **Async/Await**: All database operations use asynchronous methods for better performance

## Troubleshooting

### Database Connection Issues
If you encounter "Login failed" errors, ensure:
- SQL Server is running
- The connection string includes `Integrated Security=True`
- Your Windows user has permissions to create/access databases

### Migration Issues
If migrations fail, try:
```bash
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update
```
