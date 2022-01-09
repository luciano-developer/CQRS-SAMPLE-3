# CQRS-SAMPLE-3
Sample .NET Core REST API CQRS implementation with raw SQL and DDD using Clean Architecture.



Create DataBase and migrations (.NET CLI or PowerShell CLI)

-------------------------------------------

1 - dotnet ef migrations add NewMigration --startup-project ../Ordering.WebApi/Ordering.WebApi.csproj
2 - dotnet ef database update --startup-project ../Ordering.WebApi/Ordering.WebApi.csproj

TO REMOVE migrations

dotnet ef migrations remove --startup-project ../Ordering.WebApi/Ordering.WebApi.csproj


TO DROP DataBase

dotnet ef database drop --startup-project ../Ordering.WebApi/Ordering.WebApi.csproj


-------------------------------------------

**choose default project where's ContextClass before run commands

1 - Add-Migration InitialMigration
2 - Update-Database -Verbose

TO REMOVE migrations

Remove-Migration -force


TO DROP DataBase

Remove-Database


Remove-Migration -force; Add-Migration InitialMigration; Remove-Database; Update-Database;


