Create database BlazorDataTest
USE BlazorDataTest
CREATE TABLE EmployeeModel
(
Id INT PRIMARY KEY IDENTITY (1,1),
Name varchar(30),
Status varchar(15),
Skills varchar(50),
InProject varchar(10))

Scaffold-DbContext "Server=MLI-LAP-0125;Database=Test;Integrated Security=True;TrustServerCertificate=True"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force