# User Stories

This document contains technical stories for the `hello-asp-net-developer` REST API from the perspective of a developer interacting with it through HTTP requests. 

## TS01: Retrieve Greeting via GET Request
**As a developer**, I want to retrieve a greeting by providing optional first and last names, so that I can test the API with both named and anonymous inputs.

### Acceptance Criteria
- **Scenario 1: Anonymous Greeting**
    - **Given** a developer has not provided any names,
    - **When** the developer requests a greeting via GET,
    - **Then** the developer receives a response with the message "Welcome Anonymous ASP.NET Developer".

- **Scenario 2: Personalized Greeting**
    - **Given** a developer has provided the first name "John" and last name "Doe",
    - **When** the developer requests a greeting via GET,
    - **Then** the developer receives a response containing a unique identifier, the full name "John Doe", and the message "Congrats John Doe! You are an ASP.NET Developer".

- **Scenario 3: Partial Input**
    - **Given** a developer has provided only the first name "John" without a last name,
    - **When** the developer requests a greeting via GET,
    - **Then** the developer receives a response with the message "Welcome Anonymous ASP.NET Developer".

## TS02: Create Greeting via POST Request
**As a developer**, I want to create a greeting by providing first and last names, so that I can generate a personalized greeting with a proper creation confirmation.

### Acceptance Criteria
- **Scenario 1: Anonymous Greeting**
    - **Given** a developer has not provided any names,
    - **When** the developer submits a greeting creation request via POST,
    - **Then** the developer receives a creation confirmation with the message "Welcome Anonymous ASP.NET Developer".

- **Scenario 2: Personalized Greeting**
    - **Given** a developer has provided the first name "John" and last name "Doe",
    - **When** the developer submits a greeting creation request via POST,
    - **Then** the developer receives a creation confirmation containing a unique identifier, the full name "John Doe", and the message "Congrats John Doe! You are an ASP.NET Developer".

- **Scenario 3: Whitespace Handling**
    - **Given** a developer has provided the first name " John " and last name " Doe " with extra whitespace,
    - **When** the developer submits a greeting creation request via POST,
    - **Then** the developer receives a creation confirmation containing a unique identifier, the full name "John Doe", and the message "Congrats John Doe! You are an ASP.NET Developer".