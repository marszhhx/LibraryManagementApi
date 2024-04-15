# Library Management API

## Prerequisites

Before running this application, ensure you have installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- A suitable IDE such as [Visual Studio](https://visualstudio.microsoft.com/), [VS Code](https://code.visualstudio.com/), or JetBrains Rider

## Setup

### 1. Clone the Repository

Clone the project repository and navigate into the project directory:

```bash
git clone https://github.com/marszhhx/LibraryManagementApi.git
cd LibraryManagementApi
```

### 2. Install Dependencies
Dependencies are automatically restored when you build the project. However, you can manually restore them by running:

```bash
dotnet restore
```

## Running the Application
To run the application, use the following command from the project directory:

```bash
dotnet run
```

## Using Swagger
Use Swagger (OpenAPI) with a simple ASP.NET Core Web API that supports CRUD (Create, Read, Update, Delete) operations. Swagger offers a powerful interface for easily testing and documenting APIs.


### Accessing Swagger UI
```bash
https://localhost:[port number]/swagger
```

### Using Swagger to Perform CRUD Operations

#### Get All (GET)
* Locate the GET endpoint to retrieve all entities.
* Click "Try it out".
* Click "Execute".
* Review the response output in the Swagger UI.

#### Create (POST)
* Navigate to the POST endpoint section in Swagger UI.
* Click the "Try it out" button.
* Edit the request body to include the data for the new entity.
* Click "Execute" to send the request.
* Swagger will display the request body, response code, and response body.

#### Get One (GET)
* Locate the GET endpoint to retrieve a single entity by ID.
* Click "Try it out".
* For single entity retrieval, input the ID of the entity.
* Click "Execute".
* Review the response output in the Swagger UI.

#### Update (PUT)
* Navigate to the PUT endpoint section.
* Click "Try it out".
* Input the ID of the entity to update and modify the request body as needed.
* Click "Execute".
* Swagger will show the request data and the response for the operation.

#### Delete (DELETE)
* Find the DELETE endpoint in Swagger UI.
* Click "Try it out".
* Enter the ID of the entity you want to delete in the required field.
* Click "Execute".
* The response will confirm deletion.

