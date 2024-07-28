JWT Web API
Overview
This is a simple Web API built with ASP.NET Core that demonstrates the use of JSON Web Tokens (JWT) for authentication and authorization.

Features
User authentication with JWT
Role-based authorization
Secure endpoints
Example API endpoints for user management
Getting Started
Prerequisites
.NET Core SDK (version 6.0 or later)
SQL Server (or any other database configured in the project)
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/maduradevDotNet/JWTWeb_API.git
Navigate to the project directory:

bash
Copy code
cd JWTWeb_API
Install the required dependencies:

bash
Copy code
dotnet restore
Update your appsettings.json file with the correct database connection string and JWT settings.

Run the database migrations:

bash
Copy code
dotnet ef database update
Start the application:

bash
Copy code
dotnet run
Usage
Authentication Endpoint

POST /api/auth/login
Authenticate a user and receive a JWT token.

POST /api/auth/register
Register a new user.

Protected Endpoints

GET /api/values
Access a protected resource with a valid JWT token.
Example Request
Login

bash
Copy code
curl -X POST "https://localhost:5001/api/auth/login" -H "Content-Type: application/json" -d '{"username": "user", "password": "pass"}'
Access Protected Resource

bash
Copy code
curl -X GET "https://localhost:5001/api/values" -H "Authorization: Bearer YOUR_JWT_TOKEN"
Configuration
JWT Secret: Set the JWT secret in appsettings.json under the Jwt section.
Database Connection: Update the connection string for your database in appsettings.json.
Contributing
Fork the repository.
Create a feature branch (git checkout -b feature/YourFeature).
Commit your changes (git commit -am 'Add new feature').
Push to the branch (git push origin feature/YourFeature).
Create a new Pull Request.
License
This project is licensed under the MIT License - see the LICENSE file for details.
