[![GitHub issues](https://img.shields.io/github/issues/tomfrenzel/CustomerAPI-backend)](https://github.com/tomfrenzel/CustomerAPI-backend/issues) [![GitHub license](https://img.shields.io/github/license/tomfrenzel/CustomerAPI-backend)](https://github.com/tomfrenzel/CustomerAPI-backend/blob/master/LICENSE) ![GitHub release (latest by date)](https://img.shields.io/github/v/release/tomfrenzel/CustomerAPI-backend)  [![Build Status](https://dev.azure.com/tmfr/tmfr-customerapi-backend/_apis/build/status/tomfrenzel.CustomerAPI-backend?branchName=master)](https://dev.azure.com/tmfr/tmfr-customerapi-backend/_build/latest?definitionId=20&branchName=master)

# CustomerAPI backend

This C# Application serves as a backend server that connects to a Database and outputs the Data ready to get used with an API.


## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

This Application uses Microsoft Azure as Provider of the Database and Key Vault to store the Connection String.


### Prerequisites

.Net Core version 3.0.*
```
dotnet --version
```


### Installing

#### Connect your Database
 
Change the following line of the Startup.cs file:
```
options.UseSqlServer(Configuration["ConnectionString"]));
```
to:
```
options.UseSqlServer(Configuration["YOUR_CONNECTIONSTRING"]));
```
If your are using Microsoft Azure Key Vault

or:
```
options.UseSqlServer(Configuration.GetConnectionString("YOUR_CONNECTIONSTRING")));
```
If you are specifiyng your Connection String inside the appsettings.json file.

#### Create the Database Tables

Adding Migration to the Project allows you to Update your Database directly out of Visual Studio without having to access your Database Admin Panel and make changes manually.
```
Add-Migration Initial
Update-Database
```
#### Recieve your output

If you now Debug the Application you should get a JSON output from the Browser Window that has just opened. 


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
