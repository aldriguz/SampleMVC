# SampleMVC

This webproject runs over ASPNET Core with EntityFrameworkCore

## Requeriments to run
* Visual Studio
* IIS Express

## Connection string

```
Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=SampleMvcDb;Integrated Security=True;Pooling=False
```

## Instructions

1. Open solution (.sln) with Visual Studio
2. Create a database with name: "SampleMvcDb", using Visual Studio > Server Explorer
2.1 Using Server Explorer create a new database,  put "(LocalDb)\\MSSQLLocalDB" on Server name
2.2 Use "SampleMvcDb" on new database name
3. Add a new connection for the new database created using Server Explorer
4. Open a new query (by right-click on the database in Server Explorer)
5. Run the script placed on "Database\01_CreateTableProperties.sql" folder
6. Now run the proyect using Visual Studio
7. Try adding a property item by clicking on Save button

