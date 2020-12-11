Challenge Statement

Prerequisites
	- Any IDE
	- .NET Core SDK 5.0.101

=====================================
Development Environment
=====================================

dotnet run

- The application will be listening on http://localhost:5000
- Now you can call the api using any tool, like Postman, Curl, etc (See "Some Curl command examples" section)

=====================================
To run unit tests
=====================================
- On any terminal move to the "crossblog.tests" folder (the folder containing the "crossblog.tests.csproj" file) and execute these commands:

dotnet restore
dotnet build
dotnet test
