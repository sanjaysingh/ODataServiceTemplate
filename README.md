OData Service Template
====================

This project template aims to help you quickly get started with OData service development. It is based on WCF Data Services to create OData services.

It supports Json out of the box and has a SQL CE based data source to demonstrate the use of different query syntaxes in OData.

This project template gets installed under Visual C# section in Create New Project wizard. Alternatively you can just search for "odata"in the search bar of Create New Project wizard to get to it quickly. Look for "SampleODataApplication".

When you create a new project based on this template, you can just F5 and get it going. Following are some of the URLs you can try in the browser:

1. Get all employees in Atom format

 http://localhost:9090/Employees

2. Get all employees in JSON format

http://localhost:9090/Employees?$format=json

3. Get employee with Id 2 in JSON format

http://localhost:9090/Employees(2)?$format=json

4. Get count of employees

http://localhost:9090/Employees/$count

5. Get FirstName of the employee with Id "1".

http://localhost:9090/Employees(1)/FirstName/$value

6. Get employees with less than 2 years of age in JSON format

http://localhost:9090/Employees?$filter=Age lt 25&$format=json

7. Get project details of employee with id "1"

http://localhost:9090/Employees(1)/Project?$format=json

8. Get employee and his project details

http://localhost:9090/Employees(1)?$format=json&$expand=Project

9. Get project name of employee with id "1"

http://localhost:9090/Employees(1)/Project/Name/$value

 

Above URLs cover a variety of different types of queries that are possible with OData. The above list of queries are not exhaustive but still can be a good starting point.
