# EFLite

Spike of Entity Framework, SQLite, and .Net Core

Most of this code came from the [Getting Started with EF Core on .NET Core Console App with a New database](https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite) tutorial.

## Running

1. Clone this repository
1. `cd ConsoleApp.SQLite`
1. Restore nuget packages: `dotnet restore`
1. Run it: `dotnet run`

## Setting up the Linux Box

1. [Install WSL](https://msdn.microsoft.com/en-us/commandline/wsl/install-win10) (reboot after this)
    ```cmd
    Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux
    ```
1. [Install Ubuntu from the store](https://www.microsoft.com/en-us/store/p/ubuntu/9nblggh4msv6)
1. Log into your new Linux box
1. [Install .Net Core](https://www.microsoft.com/net/core#linuxubuntu)
    ```bash
    sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-xenial-prod xenial main" > /etc/apt/sources.list.d/dotnetdev.list'
    sudo mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg
    sudo apt-get update
    sudo apt-get install dotnet-sdk-2.0.0
    ```
1. Optionally, install the SQLite client for Linux
    ```bash
    sudo apt-get install sqlite3
    ```
1. Install DotNet 1.0.4 (for Cake support)
    ```bash
    sudo apt-get install dotnet-dev-1.0.4
    ```

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

I wrote this using Windows Subsystem for Linux (WSL).  As such,
I went back and forth between editing/running the code in Linux
(vim) and Windows (vim/VSCode).

When switching from one to the other, things may not work
unless you run the `dotnet restore` command.  This is required
in the following circumstances:

* Building/debugging in VSCode after switching from Linux
* Running cake (`build.ps1` or `build.sh`) when switching

*Note:* that this only impacted me because I was editing the
**same copy** of the project from both environments.  Had I
checked out either the Linux or Windows version to another
directory, I would not have had to run restore.

## Build Status

| Status | Environment |
|--------|-------------|
| [![Build status](https://ci.appveyor.com/api/projects/status/t8l8xx1c7kalk4b2?svg=true)](https://ci.appveyor.com/project/jquintus/eflite) | Windows |
| [![Build Status](https://travis-ci.org/jquintus/EFLite.svg?branch=master)](https://travis-ci.org/jquintus/EFLite) | Linux |
