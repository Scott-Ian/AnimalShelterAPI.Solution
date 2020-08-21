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

_The base route for this API: http://localhost:5000/_

Routes and endpoints for both Cats and Dogs are the same. For brevity, only one example has been provided below. Be aware any of these endpoints will work by replacing "Dogs" with "Cats." Please refer to the Swagger documentation for more in depth information.  

### HTTP Requests

| Request Type  | Route |
| :---------- | -----: |
| GET| /api/Dogs| 
| POST | /api/Dogs| 
| GET | /api/Dogs/{id}|
|Get| /api/Dogs/Search{searchString}
|Get| /api/Dogs/Random/ 
| PUT | /api/Dogs/{id}| 
| DELETE| /api/Dogs/{id}| 

__

### Path Parameters

| Parameter   | Type | Default | Required | Description |
| :---------- | ----- | ----- |----- |-----: |
|name | string | none | false | Searches list of Cats or Dogs by Name |
|pageSize | int | 10 | false | Sets total number of results to be returned. Maximum of 50 |
|pageNumber | int | 1 | false | Paginates the results, only providing the results from pageNumber * pageSize |

### Example Queries
 * http://localhost:5000/api/Cats?PageNumber=2&PageSize=1
 * http://localhost:5000/api/Dogs/Search?searchString=Denise


## Swagger Documentation

For a more in-depth look at the API and its endpoints please refer to the Swagger documentation:
  * Once the program is running, access the swagger documentation by visiting the following address:
    http://localhost:5000/swagger/index.html#/

__

## Note on Pagination

This API returns a default number of 10 results per page, and a maximum possible value of 50.

To modify page number, or results per page, include a "pageSize" and "pageNumber" parameter in the query.
  * Example: http://localhost:5000/api/Cats?PageNumber=2&PageSize=1

__


## Known Bugs

_There are currently no known bugs, however with the current pagination implementation, the total number of database entries is not provided, so listing the total number of results, or pages of results, is not possible._

## Support and contact details

Contact : Ian Scott IanScottDeveloper@gmail.com

## Technologies Used

* C#
* ASP.NET API
* Entity
* LINQ
* MySQL Database


## **📘 License**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)