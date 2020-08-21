# <h1 align = "center"> Animal Shelter API

## <h3 align = "center"> Entity Framework in ASP.NET MVC, 8.4.20

## <h2 align = "center"> About

<p align = "center"> An Application Programming Interface (API) that returns dogs and cats located within an Animal Shelter's database which utilizes pagination, and incorporates Swagger documentation

## **✅REQUIREMENTS**
* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)

## **💻SETUP**
* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* Ensure that MySQL is running, and update id and password in appsettings.json to reflect your local id and password configuration.
* In the project folder (AnimalShelterAPI) enter the following temrinal commands:
  1. dotnet restore
  2. dotnet ef database update
* To launch the program run the following:
  1. dotnet run
* To make api requests, I reccomend downloading and utilizing the free software Postman. 
* For a full list of routes/endpoints see the route documentation subsection within this README.md file

__

## Route Documentation

For a more in-depth look at the API documentation please refer to the Swagger documentation.
  * Once the program is running, access the swagger documentation by visiting the following address:
    http://localhost:5000/swagger/index.html#/

| Behavior    | Input | Output |
| :---------- | ----- | -----: |
| Program can create a stylist object | none | none |
| Stylist object holds stylist name and details | none | none |
| Program can retrieve a list of all stylists | none | list |
| Program can show details of stylist | none | details |
| Program can create a Client object | none | none |
| Stylist => Client reflects one to many relationship | none | none |
| Client object holds client name and phone number | none | none |
| Program can retrieve a list of all clients related to a particular stylist | none | list |

## Note on Pagination





## Known Bugs

_There are currently no known bugs, however with the current pagination implementation, the total number of database entries is not provided, so listing the total number of results, or pages of results, is not possible._

## Support and contact details

Contact : Megan Hepner

## Technologies Used

* C#
* ASP.NET MVC
* Entity


## **📘 License**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)