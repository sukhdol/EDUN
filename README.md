# EDUN
# Nude Solutions - Technical Assignment - ASP.NET Core 3.1 and Angular 8 (SPA) 

This is a Single Page App (SPA) with Angular and ASP.NET for Nude Solutions developer assignment. 

## Technologies

* .NET Core 3.1
* ASP .NET Core 3.1
* Entity Framework Core 3.1
* Angular 8
* Bootstrap 4 with Font Awesome
* AutoMapper 9
* FluentAPI
* ASP.NET Core: Built-in IoC Container

## Architecture/Principles

* CLEAN Architecture (Domain, Infrastructure, Application and WebUI)
* N-Tier Architecture
* Unit of Work
* Repository Pattern 
* Service Layer
* SOLID Principles
* Separation of concerns, DRY and KISS
* Inversion of Control (Dependency Injection)
* Code-First Migrations

## Getting Started

1. Install the latest [.NET Core SDK](https://dotnet.microsoft.com/download)
2. Install the latest [Node.js LTS](https://nodejs.org/en/)
3. Navigate to `EDUN\EDUN` and run `dotnet ef database update --project src\EDUN.Infrastructure --startup-project src\EDUN.WebUI` to create the database
4. Navigate to `EDUN\EDUN\src\EDUN.WebUI\ClientApp` and run `npm install` to install node packages
5. Navigate to `EDUN\EDUN\src\EDUN.WebUI` and run `dotnet run` to run the project

## Future Improvements

* Apply generic/base domain, service and repository classes for identical properties and methods
* Use MediatR to handle data/events/methods
* Apply FluentValidation for validating models
* Create Domain Unit Tests, Application Unit and Integration Tests
* Add a Log Framework

