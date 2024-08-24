# JWT Web API

![Banner Animation](https://your-animation-url.com/banner.gif)

## Overview

This is a simple Web API built with ASP.NET Core that demonstrates the use of JSON Web Tokens (JWT) for authentication and authorization.

![Overview Animation](https://your-animation-url.com/overview.gif)

## Features

- **User authentication with JWT**
- **Role-based authorization**
- **Secure endpoints**
- **Example API endpoints for user management**

![Features Animation](https://your-animation-url.com/features.gif)

## Getting Started

### Prerequisites

- **.NET Core SDK** (version 6.0 or later)
- **SQL Server** (or any other database configured in the project)

### Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/maduradevDotNet/JWTWeb_API.git
    ```

    ![Clone Repo Animation](https://your-animation-url.com/clone-repo.gif)

2. **Navigate to the project directory:**

    ```bash
    cd JWTWeb_API
    ```

3. **Install the required dependencies:**

    ```bash
    dotnet restore
    ```

4. **Update your `appsettings.json` file** with the correct database connection string and JWT settings.

5. **Run the database migrations:**

    ```bash
    dotnet ef database update
    ```

6. **Start the application:**

    ```bash
    dotnet run
    ```

    ![Run App Animation](https://your-animation-url.com/run-app.gif)

## Usage

- **Authentication Endpoint**

    **POST /api/auth/login**  
    Authenticate a user and receive a JWT token.

    **POST /api/auth/register**  
    Register a new user.

    ![Authentication Endpoint Animation](https://your-animation-url.com/auth-endpoints.gif)

- **Protected Endpoints**

    **GET /api/values**  
    Access a protected resource with a valid JWT token.

    ![Protected Endpoints Animation](https://your-animation-url.com/protected-endpoints.gif)

## Example Request

- **Login**

    ```bash
    curl -X POST "https://localhost:5001/api/auth/login" -H "Content-Type: application/json" -d '{"username": "user", "password": "pass"}'
    ```

    ![Login Request Animation](https://your-animation-url.com/login-request.gif)

- **Access Protected Resource**

    ```bash
    curl -X GET "https://localhost:5001/api/values" -H "Authorization: Bearer YOUR_JWT_TOKEN"
    ```

    ![Access Resource Animation](https://your-animation-url.com/access-resource.gif)

## Configuration

- **JWT Secret:** Set the JWT secret in `appsettings.json` under the `Jwt` section.
- **Database Connection:** Update the connection string for your database in `appsettings.json`.

![Configuration Animation](https://your-animation-url.com/configuration.gif)

## Contributing

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Create a new Pull Request.

![Contributing Animation](https://your-animation-url.com/contributing.gif)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

![License Animation](https://your-animation-url.com/license.gif)
