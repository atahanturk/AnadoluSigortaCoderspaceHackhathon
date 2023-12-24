In the this directory you can find backend codes of the project. To run the backend, you need to clone the repository then create a server and database according to appsetting.json file. After that you need to create and update migrations with these commands:

- dotnet ef migrations add backendMigration
- dotnet ef database update

Then you can run the code with the:

-dotnet run

command. You can find the frontend code in "frontend" directory.

