# _Places You've Been_

#### _Epicodus Project May 20, 2020_

#### By _**Jessica Hvozdovich and Khan Sahab**_

## Description

_A project to introduce the C# language and the .NET Core framework. A website to log places we've traveled as an online diary. Back-end logic will test a place constructor and be integrated into a user form to add entries. It will also serve as an introduction to proper RESTful practices and naming conventions._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the commands dotnet restore, dotnet build, and dotnet run.

## Known Bugs

There are no known bugs at the time of this update.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/places-youve-been-csharp/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MSBuild
* Razor
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User can add a city, an image url, a travel companion, and a description** | User Input:”City: Barcelona, Image Url: www.testimage.com, Companion: Nick Description: Saw the dancing fountains in 2017” | Output: "Places You've Been: Barcelona" |
| **User can view the the total list** | User Input:”Click-View All Entries” | Output: "Barcelona, Paris, Copenhagen" |
| **User can view trip details** | User Input:”Click-Barcelona” | Output: "City: Barcelona, Image Url: www.testimage.com, Companion: Nick Description: Saw the dancing fountains in 2017" |
| **User can delete all items** | User Input:”Click-Remove All Entries” | Output: "You've cleared all your entries." |
| **User can delete one item** | User Input:”Click-Remove This Entry” | Output: "You've cleared this entry." |

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jessica Hvozdovich and Khan Sahab_**