# EFLite

Spike of Entity Framework, SQLite, and .Net Core

Most of this code came from the [Getting Started with EF Core on .NET Core Console App with a New database](https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite) tutorial.

## Creating a new migration

1. Edit [Model.cs](ConsoleApp.Sqlite/Model.cs)
1. Update BloggingContext if a new table has been added
1. Create a new migration
    ```cmd
    dotnet ef migrations add [name of migration]
    ```
1. Update the database
    ```cmd
    dotnet ef database update
    ```
1. Run the application
    ```cmd
    dotnet run
    ```

## Switching between Linux and Windows

I wrote this using Windows Subsystem for Linux (WSL).  As such, I went back and forth between editing/running the code in Linux (vim) and Windows (vim/VSCode). Prior to debugging from VSCode you need to run `dotnet restore` on windows.  And then to switch back to running on Linux run the `dotnet restore` command again on Linux.
