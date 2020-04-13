# _Shelter API_

#### _A C#/sql web API that allows the user to get, post, update and delete listing of animals available for adoption in a shelter using methods, queries and endpoints._

#### By _**Rachel Schieferstein**_

## Description

_This is a SQL/C#-based web API. The user can (through Postman or similar program) GET, PUT, DELETE and POST. There is a custom endpoint for pulling a random result, and parameters for filtering and sorting, which can all be used alone or separately. It includes API Versioning (default url is 1.0, 2.0 has less functionality and can be used by changing the url to "/api/2.0/messages".) It uses ASP.NET, Entity, NSwag, branching logic, classes, methods and auto-implemented properties. NSwag/Swagger documentation is available at http://localhost:5000/swagger after the API is set up and running._

## Setup/Installation Requirements


* _Clone or download from Github Repository._
* _Install .NET Core SDK_
* _Install MySQL and start and login to a local server._
* _Recreate the database by running the migration command "dotnet ef database update"_
* _Navigate the terminal in the "ShelterAPI" directory in the project, and run "dotnet restore"_
* _In the terminal in the "ShelterAPI" directory, type "dotnet run"._
* _Enter the commands as specified below or in http://localhost:5000/swagger into Postman or similar application to perform CRUD functionalities._

## Specs

| Endpoint/Parameter example | HTTPAction | Return Data |
| ------------- |:-------------:| -------------------:|
|api/animals/| GET|A list of all animals in the shelter|
|api/animals/?species=cat| GET | All animals of given species (cat or dog)|
|api/animals/?breed=dachsund| GET | All animals of given breed|
|api/animals/?name=bert| GET | All animals with a given name|
|api/animals/?gender=female| GET | All animals with a given gender|
|api/animals/?age=4| GET | All animals with a given age |
|api/animals?sortColumn=age| GET| All animals sorted by age, or any other column heading|
|api/animals?gender=female&sortColumn=name| GET |All female animals sorted by name|
|api/animals| POST| A new sequentially IDed animal with the fields name, breed, species, age and gender added to the API database|
|/api/animals/{id}| GET| Details for specified animal with corresponding id|
|/api/animals/{id}|PUT|Editing all details for an existing animal with specified id|
|/api/animals/{id}|DELETE|Deleting specified animal with corresponding id|
|/api/animals/random|GET|Retrieves a random Animal from the database|

## Known Bugs

N/A

## Support and contact details

_If there are any questions, please contact me at violenza@gmail.com._

## Technologies Used

_This project was created using VS Code, EF Migrations, Entity Framework 2.2.6, ASP.NET, NSwag 13.3.0, MVC Versioning 4.1.0 and Postman._

### License

*This software is licensed under the MIT license.*

Copyright (c) 2020 **_Rachel Schieferstein_**