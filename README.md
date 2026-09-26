# AGGRO: All Games Game Reviews Online

A game review web app built with **ASP.NET Core MVC** and **Entity Framework Core**. Originally built as a college term project at Northwestern Michigan College and later updated to .NET 10.

## Features

- Browse a catalog of 20+ games with sorting by name, creator and release date
- Read 60 seeded player reviews, and write, edit and delete your own
- Organize games into categories
- User registration and login with ASP.NET Core Identity
- Role-based access (Administrator, Manager, User) controlling who can manage games, categories and roles
- Interactive home page (custom JavaScript and CSS)

## Tech stack

- C# / ASP.NET Core MVC (.NET 10)
- Entity Framework Core with code-first migrations
- SQL Server (LocalDB for development)
- ASP.NET Core Identity
- Bootstrap, HTML, CSS, JavaScript

## Run it locally

1. Open `AllGamesGameReviews.sln` in Visual Studio 2022 or newer (with the .NET 10 SDK).
2. Apply the database migrations in the Package Manager Console:
   ```
   Update-Database -Context ApplicationDbContext
   Update-Database -Context GameContext
   ```
3. Press F5 to run.
