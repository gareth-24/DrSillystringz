# Dr. Sillystringz' Factory App

#### Web app using C#, EF Core, and SQL to create and display machines and engineers for a factory.

#### By Gareth Grindeland

## Technologies Used

* Git
* C#/.NET version 6.0.402
* MySQL Workbench
* Enity Framework Core version 6.0.0
* HTML & CSS
* Bootstrap version 5.2.3


## Description
_This is an MVC web application that allows the user to input and store information about machines and the engineers that are licensed to repair and operate them. Basic CRUD functionality has been implemented so that a factory manager can add, edit, and delete elements on the lists as well as change which engineers are assigned to each machine. If the user leaves a form field empty, an error message will be displayed to prompt them to resubmit. This project was completed as an indpendent code review for week 11 of Epicodus to practice using the MVC model and Entity Framework Core to build a database with a many-to-many relationship._

## Setup/Installation Requirements

* _Clone this repository to your desktop._
* _Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory at ```./DrSillystringz/Factory/```._

#### To Configure and Access the Database:
* _Within the production directory "Factory", create a new file called ```appsettings.json```._
* _Within ```appsettings.json```, put the following code, replacing the "uid" and "pwd" values (in the brackets below) with your own username and password for MySQL. Also replace the "database" value with your desired database name._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _Run the terminal command ```dotnet ef database update``` to create the initial MySQL database._

#### To Run the App in the browser:
* _Navigate to this project's production directory named "Factory"._
* _Run ```dotnet watch run``` in the command line to start the application in development mode with a watcher. This will open the webpage in your browser._
* _To exit out of the application, you can use the keyboard command "CTRL+C" on Mac and Windows._
* _Optionally, you can run ```dotnet build``` within the production directory to compile this app without running it._


## Known Bugs

* _No Known Issues_

## License

_MIT License_

_Copyright (c) 2023 Gareth Grindeland_