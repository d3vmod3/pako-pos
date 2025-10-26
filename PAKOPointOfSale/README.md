#Install Nuget Packages for Database migrations
1. In Visual Studio, go to Tools > NuGet Package Manager > Package Manager Console.

2.Run the following commands one at a time in the Pacakage Manager Console located at the bottom of this window:
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools

3. To start migration, run this command "Add-Migration InitialCreate"
4. And then, run this command "Update-Database"
5. Go to terminal and type "cd Drive:\location\of\your\project"
6. Finally, run the following commands one at a time to seed the database:
dotnet ef migrations add SeedAllData
dotnet ef database update


#Note: Ensure the connection string is correct; steps 3 and 4 will fail if it’s incorrect.

#If you want to migrate fresh (drop datababase and create and seed again)
Run the following commands on Package Manager Console terminal:
Drop-Database



#For PDF printing, run:
Install-Package PdfSharp.NETStandard