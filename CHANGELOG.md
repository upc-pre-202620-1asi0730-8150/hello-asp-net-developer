# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.1.0] - 2026-08-20

### Added
- `PersonName` Value Object in domain model to encapsulate name behavior, validation, and trimming.
- `IGreetingCounter` domain service and `GreetingCounter` thread-safe singleton implementation for tracking greeting metrics.
- `GreetingEndpoints` extension class in REST interface layer to modularize Minimal API route mappings.
- `GetGreetingCountResponse` resource record to represent greeting count in REST interface.
- `[UsedImplicitly]` attribute annotations on REST request and response resource records (`GreetDeveloperRequest`, `GreetDeveloperResponse`).
- Unit test suite project `Acme.Hello.Platform.Tests` covering domain layer behavior (`PersonName` Value Object, `Developer` Entity, and `GreetingCounter` Domain Service).
- `JetBrains.Annotations` package reference (`v2026.2.0`) for code analysis and IDE inspection annotations.
- HTTP request specifications in `Acme.Hello.Platform.http` for greeting API endpoints.
- Summaries and parameter documentation for `GetGreetingCount` and `CreateGreeting` endpoints and responses.

### Changed
- Modernized `PersonName` value object into a `readonly record struct` utilizing the C# 14 `field` contextual keyword in property accessors and nullable string support.
- Modernized `Developer` entity using C# primary constructor syntax and encapsulating `PersonName` Value Object.
- Decoupled greeting count tracking from `Developer` entity and injected `IGreetingCounter` domain service in Minimal API endpoints.
- Modernized `DeveloperAssembler` and `GreetDeveloperAssembler` using pattern matching and expression-bodied methods.
- Modularized endpoint route registrations from `Program.cs` into `MapGreetingEndpoints` extension method.
- Refactored greeting endpoints with `/api/v1` version prefix and updated response handling.
- Simplified `GetGreetingCountResponse` resource record by decoupling it from domain entities.
- Refined XML documentation, parameter descriptions, and route comments across REST resources and endpoints.
- Modernized unit test suite using collection expressions (`[..]`) and LINQ range concurrency task initialization.
- Standardized namespace casing from `REST` to `Rest` and namespace from `Generic` to `Profiles`.
- Updated SDK rollForward policy, language version to C# 14, and package dependencies for .NET 10.
- Updated `docs/class-diagram.puml` with `Profiles` bounded context namespaces, `PersonName` Value Object, and `IGreetingCounter` service.
- Synchronized `docs/user-stories.md` and `README.md` with `/api/v1/greetings` endpoint signatures and greeting metrics behavior.
- Replaced `Swatchbuckle.AspNetCore` with `Scalar.AspNetCore` for OpenAPI annotations.

## [1.0.0] - 2026-08-19

### Added
- Initial release of the `hello-asp-net-developer` Minimal API application.
- `Developer` entity with greeting formatting and name validation.
- `GreetDeveloperRequest` and `GreetDeveloperResponse` REST resources and assemblers.
- `GET` and `POST` greeting endpoints.
- OpenAPI / Swagger documentation support.
- User stories and class diagram documentation.
