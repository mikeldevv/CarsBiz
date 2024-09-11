# Car Rentals and Sales Backend System

## Overview

This is a backend system designed for managing car rentals and sales. The application is built using ASP.NET Core 8 and utilizes Entity Framework for data access. The SQL Server database is run in a Docker container.

## Technologies Used

- **ASP.NET Core 8**: The web framework used to build the backend system.
- **Entity Framework**: An ORM (Object-Relational Mapper) used to interact with the database.
- **SQL Server**: The relational database management system used, running in a Docker container.

## Getting Started

To get started with this backend system, follow these steps:

### 1. Run SQL Server on Docker

Ensure you have Docker installed on your machine. Use the following command to run a SQL Server instance:

```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourPassword" -p 1433:1433 --name sql_server_container -d mcr.microsoft.com/mssql/server
