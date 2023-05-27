//Installing EF Core tools: tool install --global dotnet-ef
//Creating migrations: dotnet ef migrations add InitialMigration

using EfCoreAcademy;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite().Options;
var dbContext = new ApplicationDbContext(options);

dbContext.Database.Migrate();