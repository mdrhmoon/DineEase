## Commnad to create project
```
dotnet new sln -n DineEase -o ./
dotnet new webapi -n DineEase.API -o ./src/API
dotnet new classlib -n DineEase.Domain -o ./src/Domain
dotnet new classlib -n DineEase.Application -o ./src/Application
dotnet new classlib -n DineEase.Infrastructure -o ./src/Infrastructure/Infrastructure
dotnet new classlib -n DineEase.Persistance -o ./src/Infrastructure/Persistance
dotnet sln ./DineEase.sln add ./src/API
dotnet sln ./DineEase.sln add ./src/Domain
dotnet sln ./DineEase.sln add ./src/Application
dotnet sln ./DineEase.sln add ./src/Infrastructure/Infrastructure
dotnet sln ./DineEase.sln add ./src/Infrastructure/Persistance
```