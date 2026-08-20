# User Stories

This document contains technical stories for the `hello-asp-net-developer` REST API from the perspective of a developer interacting with it through HTTP requests. 

## TS01: Retrieve Greeting Count via GET Request
**As a developer**, I want to retrieve the count of greetings made to any developer, so that I can monitor greeting activity across the platform.

### Acceptance Criteria
- **Scenario 1: Initial Greeting Count**
    - **Given** no greetings have been created yet,
    - **When** the developer requests the greeting count via `GET /api/v1/greetings`,
    - **Then** the developer receives a 200 OK response with a payload containing `greetingCount` equal to 0.

- **Scenario 2: Updated Greeting Count**
    - **Given** one or more valid greeting requests have been processed,
    - **When** the developer requests the greeting count via `GET /api/v1/greetings`,
    - **Then** the developer receives a 200 OK response with `greetingCount` matching the number of greetings made.

## TS02: Create Greeting via POST Request
**As a developer**, I want to create a greeting by providing first and last names, so that I can generate a personalized greeting with a proper creation confirmation.

### Acceptance Criteria
- **Scenario 1: Anonymous Greeting**
    - **Given** a developer has not provided any names (or empty names),
    - **When** the developer submits a greeting creation request via `POST /api/v1/greetings`,
    - **Then** the developer receives a 201 Created confirmation with the message "Welcome Anonymous ASP.NET Developer" and the greeting count is not incremented.

- **Scenario 2: Personalized Greeting**
    - **Given** a developer has provided the first name "John" and last name "Doe",
    - **When** the developer submits a greeting creation request via `POST /api/v1/greetings`,
    - **Then** the developer receives a 201 Created confirmation containing a unique identifier, the full name "John Doe", and the message "Congrats John Doe! You are an ASP.NET Developer", and the greeting count increments by 1.

- **Scenario 3: Whitespace Handling**
    - **Given** a developer has provided the first name " John " and last name " Doe " with extra whitespace,
    - **When** the developer submits a greeting creation request via `POST /api/v1/greetings`,
    - **Then** the developer receives a 201 Created confirmation containing a unique identifier, the full name "John Doe", and the message "Congrats John Doe! You are an ASP.NET Developer", and the greeting count increments by 1.