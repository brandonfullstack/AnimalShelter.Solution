# _Animal Shelter API_

#### By _**Brandon Wright**_

#### _A deceptively simple animal shelter API_

## Technologies Used

* _C#_
* _.NET_
* _ASP.NET Core Identity_
* _Razor Pages_
* _Entity Framework Core_
* _HTML_
* _CSS_
* _Git_
* _Swashbuckle_
* _Pomelo_

## Description

_An awesome API for listing available cats and dogs at the local anima shelter._

## Setup/Installation Requirements

Note: An installation of the .NET SDK is required in order to run this application locally. See [Here](https://dotnet.microsoft.com/en-us/) for installation.

Please install Entity Framework Core by running the following command in your terminal:

`$ dotnet tool install --global dotnet-ef --version 6.0.0`

Additionally, please install the following for pagination functionality:

`$ dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.0`
`$ dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.0`


1. Copy project directory or clone repo from Github (https://github.com/brandonfullstack/AnimalShelter.Solution) to your desktop.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "AnimalShelter".
3. Create a file named `appsettings.json`: `$ touch appsettings.json`
4. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. Replace the database value with the name that you wish to give the database that will back up this application. Entity will create the `database` for you in a subsequent step.

    ```json
  {
    "Logging": {
      "LogLevel": {
        "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
      }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=root;pwd=epicodus;"
    }
  }
    ```

5. Within `appsettings.Development.json` add the following code:

    ```json
  {
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft": "Trace",
        "Microsoft.AspNetCore": "Information",
        "Microsoft.Hosting.Lifetime": "Information"
      }
    }
  }
    ```

6. Run `$ dotnet ef database update`. This command will create the database and required tables on your local machine.
7. Navigate to the project directory: `$ cd AnimalShelter`
8. In the command line, run the command `$ dotnet watch run` to compile and execute the web application.
9. Open Postman and make API calls using: http://localhost:5000.

## Known Bugs

* _No known issues_
* _Please visit this projects [GitHub repository](https://github.com/brandonfullstack/AnimalShelter.Solution) to submit Issues and Pull Requests._

## License

_[MIT](https://choosealicense.com/licenses/mit/)_

Copyright (c) _2023_ _Brandon Wright_