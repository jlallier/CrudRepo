# CrudRepo
This is the base of the CrudRepo Packages. It is not really useful on its own but should be used with other CrudRepo Packages depending on your database type.

To use this package in your .NET Core projects, either install it through the Nuget Package Manager or with this command: `Install-Package CrudRepo`

As stated, this package alone, althoug it is the base for other packages targeting specific types of databases, is not necesserily very useful on its own. If you can't find your type of database among the implemented ones, feel free to use this package as a base to implement your generic crud repositories.

Here are the supported types of database so far:
- SQL Server with Entity Framework
- MongoDb
- CosmosDB

You can find the respective packages for these different types of databases by searching for CrudRepo.[Your type of database]

If you would like to request a type of database that has not yet been implemented, feel free to open an issue with the enhancement tag in the github repository of this project. 

- - - 

## How to use these repositories in your code
In its most simple way, these repositories can be used without much effort on your part.

In your `Startup.cs` file, simply add this line