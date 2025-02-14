# Use of Copilot
1. Copilot's suggestions were used to create the program's file structure.


# User Management API

This project is a basic CRUD API for managing users in an internal user management system. It provides endpoints for creating, retrieving, updating, and deleting user information.

## Project Structure

- **Controllers**
  - `UsersController.cs`: Handles HTTP requests related to user management.
  
- **Models**
  - `User.cs`: Defines the properties of a user.
  
- **Services**
  - `UserService.cs`: Contains business logic for user management.
  
- **Program.cs**: Entry point of the application.
  
- **Startup.cs**: Configures services and middleware for the application.
  
- **UserManagementAPI.csproj**: Project file containing dependencies and build settings.

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd UserManagementAPI
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## Usage

The API provides the following endpoints:

- `POST /users`: Create a new user.
- `GET /users/{id}`: Retrieve a user by ID.
- `PUT /users/{id}`: Update an existing user.
- `DELETE /users/{id}`: Delete a user by ID.

Make sure to replace `{id}` with the actual user ID when making requests.