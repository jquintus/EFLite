///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var sln = @"ConsoleApp.Sqlite/ConsoleApp.Sqlite.csproj";
sln = @"**/*.csproj";

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////
/*
Task("Clean")
    .Does(() => 
{
    DotNetCoreClean(sln);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() => 
{
    DotNetCoreRestore(sln);
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() => 
{
     var settings = new DotNetCoreBuildSettings
     {
         Framework = "netcoreapp1.0",
         Configuration = configuration,
         OutputDirectory = "./artifacts/",
     };

    DotNetCoreBuild(sln, settings);
});

*/
Task("Default").IsDependentOn("Build");
    .Does(() => Information ("Hello WOrld"));

///////////////////////////////////////////////////////////////////////////////
// RUN
///////////////////////////////////////////////////////////////////////////////
RunTarget(target);
