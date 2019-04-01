# Dotnet API REST

This is a example, to implements a web api in layers with C# (dotnet) and Postgresql


### Architecture (Layers)

* **.API** - Layer responsible for the manipulation of routes and http requests.

* **.BLL** - Layer responsible for business rules.

* **.DAL** - Layer responsible for data modeling and access to the database.

### Run Migrations
* `cd BookStore.DAL`
* `dotnet ef database update`


### Run
After preparing your database and your connection string ( BookStore.DAL/DataBaseContext.cs ), follow the steps:

* `dotnet restore`
* `cd BookStore.API`
* `dotnet run`
* `Application is listening on http://localhost:5001`
