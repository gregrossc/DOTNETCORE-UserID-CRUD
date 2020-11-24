# ASPNETCORE-USERID-CRUD
Template starter files for ASP .NET CORE User Identity &amp; CRUD (Create, Read, Update, Delete) functionality for future projects using a PostgreSQL Database. The following example is a mock TRT clinic CRUD application.


General Instructions for setting up/generating Asp.net Core Identity for PostgreSQL with CRUD functionality.

Setting Up Asp.net Core User Tables
===================================
1. App settings.js change Default Connection to Host;Database;Port;User Id;Password;ssl;cert; (ex. "Server=lallah.db.elephantsql.com;Database=pbitjukz;Port=5432;User Id=pbitjukz;Password=PASSWORD;Ssl Mode=Require;Trust Server Certificate=true;")
2. Install the following Nuget Packages (Npgsql, Npgsql.EntityFrameworkCore.PostgreSQL, EFCore.NamingConventions, AspNetCore.Identity.EntityFrameworkCore, AspNetCore.Identity.UI, Microsoft.EntityFrameworkCore.Design, Microsoft.VisualStudio.Web.CodeGeneration.Design)
3. Add Helper.cs to Models folder to format for Postgresql (View helper.cs in this repo for exact code)
4. in Startup.cs under ConfigureServices(IServiceCollection services) change  options.UseSqlServer to options.UseNpgsql
5. Scaffold via package manager console: Scaffold-DbContext "Server=lallah.db.elephantsql.com;Database=pbitjukz;Port=5432;User Id=pbitjukz;Password=PASSWORD;Ssl Mode=Require;Trust Server Certificate=true;" Npgsql.EntityFrameworkCore.PostgreSQL -o Models
6. Delete the migrations folder
7. Rename the Table __EFMigrationsHistory to anything (Inside PostgreSQL)
8. Run the following commands in package manager console: <br>
Add-Migration InitialCreate -Context ApplicationDbContext <br>
Update-Database -Context ApplicationDbContext


Setting Up CRUD
===============
9. Create your table for CRUD data in postgresql
10. Create new controller, MVC Controller with views, using Entity Framework. Use table as Model class, name controller as TableController, Add. In Startup.cs add the following 2 lines in Configure Services below:

string connectionString = Configuration.GetConnectionString("DefaultConnection"); <br>
services.AddDbContext<pbitjukzContext>(context => context.UseNpgsql(connectionString));


*DONE*
