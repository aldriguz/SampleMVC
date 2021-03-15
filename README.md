# SampleMVC

This webproject runs over ASPNET Core with EntityFrameworkCore

## Requeriments

* Visual Studio 2019
* IIS Express
* SQL Server 

## Connection strings

Feel free to use another sql server database name, make sure that connection string is correct

```
Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=SampleMvcDb;Integrated Security=True;Pooling=False
```

## Instructions

1. Create a new sql server database using SQL Server Management (or tool your prefeer)
2. Use "(LocalDb)\\MSSQLLocalDB" and "SampleMvcDb" name to use same connection string of the project
3. Run the script from "Database\01_CreateTableProperties.sql" folder
4. Make sure that script has been executed correctly
5. Open solution (.sln) with Visual Studio
6. Now run the proyect using Visual Studio
7. Try adding a property item to the database by click on "Save" button



