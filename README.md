# Project WEB Application

## Overview

What is this Project?
This project is a **web application in development** built with **ASP.NET Core**, currently featuring:
1. A **Web API** that provides simple greetings and personalized greetings.
2. An **MVC front-end** that consumes the API and displays results on a web page.

## Features

- **ASP.NET Core Web API** for fetching greeting messages.
- **ASP.NET Core MVC front-end** for user interaction.
- Integration with **Swagger** for API documentation and testing.

## Prerequisites

Ensure you have the following installed on your machine before running the project:

- **.NET 6 SDK** or later
- **Visual Studio**:IDE for running and developing the project.
## Steps to Run the Application
1. Clone the Repository
2. Navigate to the Project Directory
3. Restore Dependencies
4. Build the Project
5. Run the Application



## Access the Application (default end points are provided below)
API Endpoints:
Fetch a simple greeting: https://localhost:7242/api/Home
Fetch a personalized greeting: https://localhost:7242/api/Home/hello?name=YourName
MVC Front-End:
Access the MVC interface at: https://localhost:7242/HomeMvc.
Use the form to get a greeting or enter a name for a personalized message.
Swagger for API Testing
Swagger is enabled to help with API testing and documentation. You can access it at:
https://localhost:7242/swagger


## Technologies Used
1. ASP.NET Core 6: Backend framework for building the Web API and MVC application.
2. C#: Programming language used for backend logic.
3. Swagger: API documentation and testing tool.
4. Visual Studio: Recommended development environment.
5. SQL Server (Optional): For future database integration.
