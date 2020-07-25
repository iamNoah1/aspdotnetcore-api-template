# ASP .Net Core API Template
This is meant to be used as a template for ASP .Net Core project that serves as an REST API.

## Run
* Change to ASP.NetCore-API-Template directory and run `dotnet run`
* Alternatively open solution in Visual Studio and run project from there

## Run with docker 
* `docker build -t <containerRegistryUserName>:asp.netcore-api-template .`
* `docker run -p 3000:80 <containerRegistryUserName>:asp.netcore-api-template`

## Endpoints
See [swagger spec](./api-spec.yml). 

## Unit Tests
* Change to ASP.NetCore-API-Template directory and run `dotnet test`
* Alternatively open solution in Visual Studio and run tests from there
